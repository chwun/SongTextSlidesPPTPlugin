﻿using Microsoft.Office.Tools.Ribbon;
using SongTextSlides.Logic;
using SongTextSlides.Models;
using System.IO;
using System.Windows.Forms;

namespace SongTextSlides
{
	public partial class SongTextSlidesRibbon
	{
		#region event handlers

		private void SongTextSlidesRibbon_Load(object sender, RibbonUIEventArgs e)
		{
		}

		private void ButtonNewSong_Click(object sender, RibbonControlEventArgs e)
		{
			ShowSongDialog(null);
		}

		private void ButtonSelectSong_Click(object sender, RibbonControlEventArgs e)
		{
		}

		private void ButtonInfo_Click(object sender, RibbonControlEventArgs e)
		{
			InfoDialog infoDialog = new InfoDialog();
			infoDialog.ShowDialog();
		}

		private void ButtonOpenSongFile_Click(object sender, RibbonControlEventArgs e)
		{
			string filename = GetFileName();

			if (string.IsNullOrWhiteSpace(filename))
			{
				return;
			}

			if (!File.Exists(filename))
			{
				MessageBox.Show("Die angegebene Datei existiert nicht", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SongFileImport import = new SongFileImport();

			if (!import.ImportSong(filename, out Song importedSong, out string errorMessage))
			{
				MessageBox.Show(errorMessage, "Fehler beim Öffnen des Lieds", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ShowSongDialog(importedSong);
		}

		#endregion event handlers

		#region private methods

		/// <summary>
		/// Shows edit dialog for the given song as modal dialog
		/// </summary>
		/// <param name="song">existing song to show in edit dialog</param>
		private void ShowSongDialog(Song song)
		{
			EditSongDialog newSongDialog = new EditSongDialog(song);
			newSongDialog.ShowDialog();
		}

		/// <summary>
		/// Opens a file dialog and returns the selected file path
		/// </summary>
		/// <returns>file path if a file was selected; otherwise empty string</returns>
		private string GetFileName()
		{
			using (OpenFileDialog fileDialog = new OpenFileDialog())
			{
				fileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
				fileDialog.RestoreDirectory = true;

				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					return fileDialog.FileName;
				}
				else
				{
					return string.Empty;
				}
			}
		}

		#endregion private methods
	}
}