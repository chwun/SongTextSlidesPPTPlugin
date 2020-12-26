using Serilog;
using SongTextSlides.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SongTextSlides.Logic
{
	/// <summary>
	/// Class for parsing song texts
	/// </summary>
	public class SongTextParser
	{
		/// <summary>
		/// Parses the given song text and returns a list of song parts
		/// </summary>
		/// <param name="songText">song text</param>
		/// <param name="parsedSongParts">parsed song parts</param>
		/// <param name="errorMessage">error message, if not successful</param>
		/// <returns>true, if parsing was successful</returns>
		public bool ParseSongText(string songText, out List<SongPart> parsedSongParts, out string errorMessage)
		{
			parsedSongParts = new List<SongPart>();
			errorMessage = "";

			if (string.IsNullOrWhiteSpace(songText))
			{
				// empty song text not allowed
				return false;
			}

			try
			{
				var lines = songText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).Select(x => x.Trim());

				SongPart lastSongPart = null;

				foreach (string line in lines)
				{
					// if line is empty, last song part is finished:
					if (string.IsNullOrWhiteSpace(line))
					{
						lastSongPart = null;
					}
					// if last song part is set, append line to that song part:
					else if (lastSongPart != null)
					{
						lastSongPart.TextLines.Add(line);
					}
					else
					{
						SongPart newSongPart;

						// blank slide:
						if (line == Constants.BlankSlidePlaceholder)
						{
							newSongPart = new SongPart(SongPartType.Blank);
						}
						// new lyrics part:
						else
						{
							newSongPart = new SongPart(SongPartType.Lyrics, line);
						}

						parsedSongParts.Add(newSongPart);
						lastSongPart = newSongPart;
					}
				}

				return true;
			}
			catch (Exception e)
			{
				Log.Error(e, "SongTextParser.ParseSongText(): error parsing song text {songText}", songText);

				parsedSongParts.Clear();
				errorMessage = "Interner Fehler beim Einlesen des Liedtextes";

				return false;
			}
		}
	}
}