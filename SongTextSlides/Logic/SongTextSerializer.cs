using SongTextSlides.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SongTextSlides.Logic
{
	/// <summary>
	/// Class for converting a list of song parts to its text representation
	/// </summary>
	public class SongTextSerializer
	{
		/// <summary>
		/// Gets a text representation of the given song parts
		/// </summary>
		/// <returns></returns>
		public static string SerializeSongParts(List<SongPart> songParts)
		{
			StringBuilder sb = new StringBuilder();

			foreach (SongPart part in songParts)
			{
				if (part.Type == SongPartType.Lyrics)
				{
					foreach (string textLine in part.TextLines)
					{
						sb.AppendLine(textLine);
					}
				}
				else if (part.Type == SongPartType.Blank)
				{
					sb.AppendLine(Constants.BlankSlidePlaceholder);
				}
				else
				{
					throw new NotImplementedException($"song part type {part.Type} not implemented!");
				}

				sb.AppendLine();
			}

			return sb.ToString();
		}
	}
}