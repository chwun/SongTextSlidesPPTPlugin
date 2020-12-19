using System;
using System.Collections.Generic;

namespace SongTextSlides.Models
{
	public class SongPart
	{
		public SongPartType Type { get; set; }

		public List<string> TextLines { get; private set; } = new List<string>();

		public SongPart(SongPartType type)
		{
			Type = type;
		}

		public SongPart(SongPartType type, string firstTextLine)
			: this(type)
		{
			TextLines.Add(firstTextLine);
		}

		public string GetSongText()
		{
			return string.Join(Environment.NewLine, TextLines);
		}
	}
}