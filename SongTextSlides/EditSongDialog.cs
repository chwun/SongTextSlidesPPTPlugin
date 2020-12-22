using Serilog;
using SongTextSlides.Logic;
using SongTextSlides.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SongTextSlides
{
	/// <summary>
	/// Dialog class for editing a new or existing song
	/// </summary>
	public partial class EditSongDialog : Form
	{
		private readonly Song song;

		#region constructors

		/// <summary>
		/// Creates a new instance of <see cref="EditSongDialog"/>
		/// </summary>
		/// <param name="mode">mode in which the dialog is opened</param>
		/// <param name="editSong">song, if dialog is opened to edit a existing song</param>
		public EditSongDialog(Song editSong)
		{
			InitializeComponent();

			InitLogging();

			if (editSong != null)
			{
				Text = "Lied bearbeiten";
				song = editSong;
				Log.Information("EditSongDialog: dialog opened for existing song {@song}", song);
			}
			else
			{
				Text = "Neues Lied";
				song = new Song();
				Log.Information("EditSongDialog: dialog opened for a new song");
			}

			InitFields();
		}

		#endregion constructors

		#region private methods

		/// <summary>
		/// Initializes logger
		/// </summary>
		private void InitLogging()
		{
			try
			{
				string logFile = Path.Combine(Path.GetTempPath(), "songtextslides.log");
				Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.File(logFile).CreateLogger();

				FormClosed += (s, e) => Log.CloseAndFlush();
			}
			catch
			{
			}
		}

		/// <summary>
		/// Initializes dialog fields
		/// </summary>
		private void InitFields()
		{
			TextBoxSongTitle.Text = song.Title;
			TextBoxSongCopyright.Text = song.CopyrightInfo;
			TextBoxCCLISongNumber.Text = song.CCLISongNumber;
			TextBoxCCLILicenseNumber.Text = song.CCLILicenseNumber;
			TextBoxSongText.Text = SongTextSerializer.SerializeSongParts(song.SongParts);
		}

		/// <summary>
		/// Confirms the dialog (OK button)
		/// </summary>
		private void ConfirmDialog()
		{
			if (!ValidateSong(out string validationErrorMessage))
			{
				Log.Information("EditSongDialog.ConfirmDialog: ValidateInput() failed (error message: {validationErrorMessage}, song: {@song})", validationErrorMessage, song);
				MessageBox.Show(validationErrorMessage, "Fehler beim Prüfen der Daten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!ApplyFields(out string parsingErrorMessage))
			{
				Log.Information("EditSongDialog.ConfirmDialog: AcceptFields failed (error message: {parsingErrorMessage}, song: {@song})", parsingErrorMessage, song);
				MessageBox.Show(parsingErrorMessage, "Interner Fehler beim Einlesen der Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// TODO: Abfrage, ob Folien eingefügt werden sollen / oder nur zur Liste hinzu

			if (!CreateSlides(out string slideCreationErrorMessage))
			{
				Log.Information("EditSongDialog.ConfirmDialog: CreateSlides failed (error message: {slideCreationErrorMessage}, song: {@song})", slideCreationErrorMessage, song);
				MessageBox.Show(slideCreationErrorMessage, "Fehler beim Erzeugen der Folien", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		/// <summary>
		/// Applies dialog fields to the song object
		/// </summary>
		/// <param name="errorMessage">error message, if not successful</param>
		/// <returns>true, if successful</returns>
		private bool ApplyFields(out string errorMessage)
		{
			song.Title = TextBoxSongTitle.Text;
			song.CopyrightInfo = TextBoxSongCopyright.Text;
			song.CCLISongNumber = TextBoxCCLISongNumber.Text;
			song.CCLILicenseNumber = TextBoxCCLILicenseNumber.Text;

			SongTextParser parser = new SongTextParser();

			if (parser.ParseSongText(TextBoxSongText.Text, out List<SongPart> songParts, out errorMessage))
			{
				song.SongParts = songParts;
				return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the song
		/// </summary>
		/// <param name="errorMessage">error message, if not successful</param>
		/// <returns>true, if successful</returns>
		private bool ValidateSong(out string errorMessage)
		{
			SongValidator validator = new SongValidator(TextBoxSongTitle.Text, TextBoxSongCopyright.Text,
				TextBoxCCLISongNumber.Text, TextBoxCCLILicenseNumber.Text, TextBoxSongText.Text);

			return validator.Validate(out errorMessage);
		}

		/// <summary>
		/// Creates slides for the song
		/// </summary>
		/// <param name="errorMessage">error message, if not successful</param>
		/// <returns>true, if successful</returns>
		private bool CreateSlides(out string errorMessage)
		{
			var presentation = Globals.ThisAddIn.Application.ActivePresentation;
			SlideCreation slideCreation = new SlideCreation(presentation);

			return slideCreation.CreateSlidesForSong(song, out errorMessage);
		}

		#endregion private methods

		#region event handlers

		/// <summary>
		/// Event handler for button click (OK button)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonOk_Click(object sender, System.EventArgs e)
		{
			ConfirmDialog();
		}

		#endregion event handlers
	}
}