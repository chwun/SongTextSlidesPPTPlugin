using Serilog;
using SongTextSlides.Configuration;
using System;
using System.Windows.Forms;

namespace SongTextSlides
{
	/// <summary>
	/// Dialog class for settings
	/// </summary>
	public partial class SettingsDialog : Form
	{
		private Settings settings;

		/// <summary>
		/// Creates a new instance of <see cref="SettingsDialog"/>
		/// </summary>
		public SettingsDialog()
		{
			InitializeComponent();

			LoadSettings();
			InitFields();

			Log.Information("SettingsDialog: dialog opened with (settings: {@settings})", settings);
		}

		#region event handlers

		private void ButtonOk_Click(object sender, EventArgs e)
		{
			ApplyFields();
			SaveSettings();
			Close();
		}

		private void ButtonChangeSongFilesDirectory_Click(object sender, EventArgs e)
		{
			SelectSongFilesDirectory();
		}

		private void TextBoxSongFilesDirectory_DoubleClick(object sender, EventArgs e)
		{
			SelectSongFilesDirectory();
		}

		#endregion event handlers

		#region private methods

		/// <summary>
		/// Loads the current settings
		/// </summary>
		private void LoadSettings()
		{
			settings = new Settings()
			{
				CCLILicenseNumber = Properties.Settings.Default.CCLILicenseNumber,
				SaveCCLILicenseNumber = Properties.Settings.Default.SaveCCLILicenseNumber,
				UseSavedCCLILicenseNumber = Properties.Settings.Default.UseSavedCCLILicenseNumber,
				SongFilesDirectory = Properties.Settings.Default.SongFilesDirectory
			};
		}

		/// <summary>
		/// Initializes dialog fields
		/// </summary>
		private void InitFields()
		{
			TextBoxCCLILicenseNumber.Text = settings.CCLILicenseNumber;
			CheckBoxSaveCCLILicenseNumber.Checked = settings.SaveCCLILicenseNumber;
			CheckBoxUseSavedCCLILicenseNumber.Checked = settings.UseSavedCCLILicenseNumber;
			TextBoxSongFilesDirectory.Text = settings.SongFilesDirectory;
		}

		/// <summary>
		/// Applies dialog fields to the settings object
		/// </summary>
		private void ApplyFields()
		{
			settings.CCLILicenseNumber = TextBoxCCLILicenseNumber.Text;
			settings.SaveCCLILicenseNumber = CheckBoxSaveCCLILicenseNumber.Checked;
			settings.UseSavedCCLILicenseNumber = CheckBoxUseSavedCCLILicenseNumber.Checked;
		}

		/// <summary>
		/// Saves the current settings
		/// </summary>
		private void SaveSettings()
		{
			Properties.Settings.Default.CCLILicenseNumber = settings.CCLILicenseNumber;
			Properties.Settings.Default.SaveCCLILicenseNumber = settings.SaveCCLILicenseNumber;
			Properties.Settings.Default.UseSavedCCLILicenseNumber = settings.UseSavedCCLILicenseNumber;
			Properties.Settings.Default.SongFilesDirectory = settings.SongFilesDirectory;

			Log.Information("SettingsDialog.SaveSettings(): saved new user settings {@settings}", settings);

			Properties.Settings.Default.Save();
		}

		/// <summary>
		/// Opens a folder browser dialog to select the song files directory
		/// </summary>
		private void SelectSongFilesDirectory()
		{
			FolderBrowserDialog.SelectedPath = settings.SongFilesDirectory;

			if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				settings.SongFilesDirectory = FolderBrowserDialog.SelectedPath;
				TextBoxSongFilesDirectory.Text = settings.SongFilesDirectory;
			}
		}

		#endregion private methods
	}
}