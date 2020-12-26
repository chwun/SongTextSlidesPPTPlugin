using Serilog;
using SongTextSlides.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SongTextSlides.Logic
{
	/// <summary>
	/// Class for importing songs from files
	/// </summary>
	public class SongFileImport
	{
		/// <summary>
		/// Imports a song from the given text file
		/// </summary>
		/// <param name="filename">path to text file</param>
		/// <param name="importedSong">imported song, if successful</param>
		/// <param name="errorMessage">error message, if not successful</param>
		/// <returns>true, if successful</returns>
		public bool ImportSong(string filename, out Song importedSong, out string errorMessage)
		{
			importedSong = null;

			try
			{
				string[] lines = File.ReadAllLines(filename);

				if ((lines == null) || (lines.Length == 0))
				{
					Log.Warning("SongFileImport.ImportSong(): nothing to import, file \"{filename}\" is empty", filename);
					errorMessage = "Datei ist leer";

					return false;
				}

				var linesQueue = new Queue<string>(lines);

				string songTitle = linesQueue.Dequeue();
				string ccliSongNumber = linesQueue.Dequeue();
				string ccliLicenseNumber = linesQueue.Dequeue();
				string copyright = "";
				string songText = "";

				StringBuilder sbCopyright = new StringBuilder();

				while (!string.IsNullOrWhiteSpace(linesQueue.Peek()))
				{
					sbCopyright.AppendLine(linesQueue.Dequeue());
				}

				copyright = sbCopyright.ToString().Trim(new[] { '\r', '\n' });

				StringBuilder sbSongText = new StringBuilder();

				while (linesQueue.Count > 0)
				{
					sbSongText.AppendLine(linesQueue.Dequeue());
				}

				songText = sbSongText.ToString();

				importedSong = new Song()
				{
					Title = songTitle,
					CCLISongNumber = ccliSongNumber,
					CCLILicenseNumber = ccliLicenseNumber,
					CopyrightInfo = copyright
				};

				SongTextParser songTextParser = new SongTextParser();

				if (!songTextParser.ParseSongText(songText, out List<SongPart> songParts, out errorMessage))
				{
					Log.Error("SongFileImport.ImportSong(): error importing song from file \"{filename}\", parsing song text not successful", filename);

					importedSong = null;
					errorMessage = "Liedtext ist ungültig";

					return false;
				}

				importedSong.SongParts = songParts;

				Log.Information("SongFileImport.ImportSong(): successfully imported song \"{songtitle}\" from file \"{filename}\"", importedSong.Title, filename);

				return true;
			}
			catch (InvalidOperationException e)
			{
				Log.Error(e, "SongFileImport.ImportSong(): error importing song from file \"{filename}\"", filename);

				importedSong = null;
				errorMessage = "Interner Fehler beim Öffnen der Datei, Datei enthält nicht alle benötigten Daten";

				return false;
			}
			catch (Exception e)
			{
				Log.Error(e, "SongFileImport.ImportSong(): error importing song from file \"{filename}\"", filename);

				importedSong = null;
				errorMessage = "Interner Fehler beim Öffnen der Datei";

				return false;
			}
		}
	}
}