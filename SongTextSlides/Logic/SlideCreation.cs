using Microsoft.Office.Interop.PowerPoint;
using Serilog;
using SongTextSlides.Models;
using System;
using System.Text;

namespace SongTextSlides.Logic
{
	/// <summary>
	/// Class for creating slides
	/// </summary>
	public class SlideCreation
	{
		private readonly Presentation presentation;

		#region constructors

		/// <summary>
		/// Creates a new instance of <see cref="SlideCreation"/>
		/// </summary>
		/// <param name="presentation">presentation file for slide creation</param>
		public SlideCreation(Presentation presentation)
		{
			this.presentation = presentation;
		}

		#endregion constructors

		#region public methods

		/// <summary>
		/// Creates slides for the given song
		/// </summary>
		/// <param name="song">song to create slides for</param>
		/// <param name="errorMessage">error message, if not successful</param>
		/// <returns>true, if slide creation was successful</returns>
		public bool CreateSlidesForSong(Song song, out string errorMessage)
		{
			if (!GetCustomLayouts(out var layoutTitle, out var layoutLyrics, out var layoutBlank))
			{
				errorMessage = $"Keine passenden Master-Folien gefunden ('{Constants.LayoutNameSongTitle}', '{Constants.LayoutNameLyrics}' und '{Constants.LayoutNameBlank}' müssen vorhanden sein)";

				return false;
			}

			if (!AddSlides(song, layoutTitle, layoutLyrics, layoutBlank))
			{
				errorMessage = "Interner Fehler beim Hinzufügen der Folien";

				return false;
			}

			Log.Information("SlideCreation.CreateSlidesForSong(): successfully created slides for song {@song}", song);

			errorMessage = "";
			return true;
		}

		#endregion public methods

		#region private methods

		/// <summary>
		/// Gets the needed custom slide layouts
		/// </summary>
		/// <param name="layoutTitle">layout for song title slide</param>
		/// <param name="layoutLyrics">layout for lyrics slide</param>
		/// <param name="layoutBlank">layout for blank slide</param>
		/// <returns></returns>
		private bool GetCustomLayouts(out CustomLayout layoutTitle, out CustomLayout layoutLyrics, out CustomLayout layoutBlank)
		{
			layoutTitle = null;
			layoutLyrics = null;
			layoutBlank = null;

			foreach (CustomLayout layout in presentation.SlideMaster.CustomLayouts)
			{
				if (layout.Name.Equals(Constants.LayoutNameSongTitle, StringComparison.OrdinalIgnoreCase))
				{
					layoutTitle = layout;
				}
				else if (layout.Name.Equals(Constants.LayoutNameLyrics, StringComparison.OrdinalIgnoreCase))
				{
					layoutLyrics = layout;
				}
				else if (layout.Name.Equals(Constants.LayoutNameBlank, StringComparison.OrdinalIgnoreCase))
				{
					layoutBlank = layout;
				}
			}

			if ((layoutTitle != null) && (layoutLyrics != null) && (layoutBlank != null))
			{
				return true;
			}
			else
			{
				Log.Error("SlideCreation.GetCustomLayouts(): custom layouts could not be fetched");

				layoutTitle = null;
				layoutLyrics = null;
				layoutBlank = null;

				return false;
			}
		}

		/// <summary>
		/// Adds all slides for the given song
		/// </summary>
		/// <param name="song">song</param>
		/// <param name="layoutTitle">layout for song title slide</param>
		/// <param name="layoutLyrics">layout for lyrics slide</param>
		/// <param name="layoutBlank">layout for blank slide</param>
		/// <returns>true, if successful</returns>
		private bool AddSlides(Song song, CustomLayout layoutTitle, CustomLayout layoutLyrics, CustomLayout layoutBlank)
		{
			try
			{
				Log.Debug("SlideCreation.AddSlides(): adding slides for song {@song}", song);

				AddTitleSlide(song, layoutTitle);
				AddSongPartSlides(song, layoutLyrics, layoutBlank);

				return true;
			}
			catch (Exception e)
			{
				Log.Error(e, "SlideCreation.AddSlides(): error adding slides for song {@song}", song);
				return false;
			}
		}

		/// <summary>
		/// Adds title slide
		/// </summary>
		/// <param name="song">song</param>
		/// <param name="layoutTitle">layout for song title slide</param>
		private void AddTitleSlide(Song song, CustomLayout layoutTitle)
		{
			int newSlideNumber = presentation.Slides.Count + 1; // no index, starts at 1

			Slide slideTitle = presentation.Slides.AddSlide(newSlideNumber, layoutTitle);
			slideTitle.Shapes.Placeholders[1].TextFrame.TextRange.Text = song.Title;
			slideTitle.Shapes.Placeholders[2].TextFrame.TextRange.Text = AssembleCopyrightBlock(song);
		}

		/// <summary>
		/// Adds slides for all song parts (lyrics and blank slides)
		/// </summary>
		/// <param name="song">song</param>
		/// <param name="layoutLyrics">layout for lyrics slide</param>
		/// <param name="layoutBlank">layout for blank slide</param>
		private void AddSongPartSlides(Song song, CustomLayout layoutLyrics, CustomLayout layoutBlank)
		{
			int newSlideNumber = presentation.Slides.Count + 1; // no index, starts at 1

			foreach (SongPart part in song.SongParts)
			{
				if (part.Type == SongPartType.Blank)
				{
					presentation.Slides.AddSlide(newSlideNumber, layoutBlank);
				}
				else if (part.Type == SongPartType.Lyrics)
				{
					Slide slideLyrics = presentation.Slides.AddSlide(newSlideNumber, layoutLyrics);
					slideLyrics.Shapes.Placeholders[1].TextFrame.TextRange.Text = part.GetSongText();
				}

				newSlideNumber++;
			}
		}

		/// <summary>
		/// Assembles copyright info, song number and license number to a single string
		/// </summary>
		/// <param name="song">song</param>
		/// <returns>single string containing copyright info, song number an license number</returns>
		private string AssembleCopyrightBlock(Song song)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(song.CopyrightInfo);

			if (!string.IsNullOrWhiteSpace(song.CCLISongNumber))
			{
				sb.Append("CCLI-Liednummer: ");
				sb.Append(song.CCLISongNumber);
				sb.Append(" | ");
				sb.Append("CCLI-Lizenznummer: ");
				sb.Append(song.CCLILicenseNumber);
			}

			return sb.ToString();
		}

		#endregion private methods
	}
}