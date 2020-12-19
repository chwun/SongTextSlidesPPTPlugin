using Serilog;
using SongTextSlides.Logic;
using SongTextSlides.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SongTextSlides
{
	public enum EditSongDialogMode
	{
		NewSong,
		ExistingSong
	}

	public partial class EditSongDialog : Form
	{
		private readonly EditSongDialogMode mode;
		private readonly Song song;

		#region constructors

		public EditSongDialog(EditSongDialogMode mode, Song editSong = null)
		{
			InitializeComponent();

			InitLogging();

			Log.Information("EditSongDialog: dialog opened in mode {mode}", mode);

			this.mode = mode;

			if (mode == EditSongDialogMode.ExistingSong)
			{
				song = editSong;
			}
			else
			{
				song = new Song();
			}

			InitFields();
		}

		#endregion constructors

		#region private methods

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

		private void InitFields()
		{
			TextBoxSongTitle.Text = song.Title;
			TextBoxSongCopyright.Text = song.CopyrightInfos;
			TextBoxSongText.Text = song.GetSongText();
		}

		private bool AcceptFields(out string errorMessage)
		{
			song.Title = TextBoxSongTitle.Text;
			song.CopyrightInfos = TextBoxSongCopyright.Text;

			SongTextParser parser = new SongTextParser();

			if (parser.TryParseSongText(TextBoxSongText.Text, out List<SongPart> songParts, out errorMessage))
			{
				song.SongParts = songParts;
				return true;
			}

			return false;
		}

		private bool ValidateInput(out string errorMessage)
		{
			SongTextValidator validator = new SongTextValidator(TextBoxSongTitle.Text, TextBoxSongCopyright.Text, TextBoxSongText.Text);
			return validator.Validate(out errorMessage);
		}

		private bool CreateSlides(out string errorMessage)
		{
			var presentation = Globals.ThisAddIn.Application.ActivePresentation;
			SlideCreation slideCreation = new SlideCreation(presentation);

			return slideCreation.CreateSlidesForSong(song, out errorMessage);
		}

		#endregion private methods

		#region event handlers

		private void ButtonOk_Click(object sender, System.EventArgs e)
		{
			if (!ValidateInput(out string validationErrorMessage))
			{
				MessageBox.Show(validationErrorMessage, "Fehler beim Prüfen der Daten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!AcceptFields(out string parsingErrorMessage))
			{
				MessageBox.Show(parsingErrorMessage, "Interner Fehler beim Einlesen der Daten", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// TODO: Abfrage, ob Folien eingefügt werden sollen / oder nur zur Liste hinzu

			if (!CreateSlides(out string slideCreationErrorMessage))
			{
				MessageBox.Show(slideCreationErrorMessage, "Fehler beim Erzeugen der Folien", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		#endregion event handlers
	}
}