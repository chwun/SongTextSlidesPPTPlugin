using System.Collections.Generic;

namespace SongTextSlides.Models
{
	/// <summary>
	/// Class for a song
	/// </summary>
	public class Song
	{
		/// <summary>
		/// Song title
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Copyright information
		/// </summary>
		public string CopyrightInfo { get; set; }

		/// <summary>
		/// Song parts (lyrics and blank slides)
		/// </summary>
		public List<SongPart> SongParts { get; set; } = new List<SongPart>();
	}
}