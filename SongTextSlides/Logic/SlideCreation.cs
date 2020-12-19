using Microsoft.Office.Interop.PowerPoint;
using Serilog;
using SongTextSlides.Models;
using System;

namespace SongTextSlides.Logic
{
	public class SlideCreation
	{
		private readonly Presentation presentation;

		#region constructors

		public SlideCreation(Presentation presentation)
		{
			this.presentation = presentation;
		}

		#endregion constructors

		#region public methods

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

		private void AddTitleSlide(Song song, CustomLayout layoutTitle)
		{
			int newSlideNumber = presentation.Slides.Count + 1; // no index, starts at 1

			Slide slideTitle = presentation.Slides.AddSlide(newSlideNumber, layoutTitle);
			slideTitle.Shapes.Placeholders[1].TextFrame.TextRange.Text = song.Title;
			slideTitle.Shapes.Placeholders[2].TextFrame.TextRange.Text = song.CopyrightInfos;
		}

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

		#endregion private methods
	}
}