namespace SongTextSlides.Configuration
{
	/// <summary>
	/// Data class for settings
	/// </summary>
	public class Settings
	{
		/// <summary>
		/// Directory for saved song files
		/// </summary>
		public string SongFilesDirectory { get; set; }

		/// <summary>
		/// True, if CCLI license number should saved automatically (if not already existing)
		/// </summary>
		public bool SaveCCLILicenseNumber { get; set; }

		/// <summary>
		/// True, if the saved CCLI license number should be inserted automatically
		/// </summary>
		public bool UseSavedCCLILicenseNumber { get; set; }

		/// <summary>
		/// Saved CCLI license number
		/// </summary>
		public string CCLILicenseNumber { get; set; }
	}
}