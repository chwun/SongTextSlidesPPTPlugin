using System;
using System.Collections.Generic;
using System.Text;

namespace SongTextSlides.Models
{
	public class Song
	{

		public string Title { get; set; }

		public string CopyrightInfos { get; set; }
		
		public List<SongPart> SongParts { get; set; } = new List<SongPart>();

		public string GetSongText()
		{
			StringBuilder sb = new StringBuilder();

			foreach (SongPart part in SongParts)
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