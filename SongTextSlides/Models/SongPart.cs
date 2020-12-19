using System;
using System.Collections.Generic;

namespace SongTextSlides.Models
{
	/// <summary>
	/// Class for a song part
	/// </summary>
	public class SongPart
	{
		/// <summary>
		/// Type of this song part
		/// </summary>
		public SongPartType Type { get; set; }

		/// <summary>
		/// List of text lines (if lyrics)
		/// </summary>
		public List<string> TextLines { get; private set; } = new List<string>();

		/// <summary>
		/// Creates a new instance of <see cref="SongPart"/>
		/// </summary>
		/// <param name="type">type</param>
		public SongPart(SongPartType type)
		{
			Type = type;
		}

		/// <summary>
		/// Creates a new instance of <see cref="SongPart"/>
		/// </summary>
		/// <param name="type">type</param>
		/// <param name="firstTextLine">first line of text</param>
		public SongPart(SongPartType type, string firstTextLine)
			: this(type)
		{
			TextLines.Add(firstTextLine);
		}

		/// <summary>
		/// Gets all lines as one text
		/// </summary>
		/// <returns>string with all text lines combined</returns>
		public string GetSongText()
		{
			return string.Join(Environment.NewLine, TextLines);
		}
	}
}