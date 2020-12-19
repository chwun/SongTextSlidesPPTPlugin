using Serilog;
using SongTextSlides.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongTextSlides.Logic
{
	/// <summary>
	/// Class for validating a song
	/// </summary>
	public class SongValidator
	{
		private readonly string title;
		private readonly string copyrightInfo;
		private readonly string text;
		private List<string> textLines;

		#region constructors

		/// <summary>
		/// Creates a new instance of <see cref="SongValidator"/>
		/// </summary>
		/// <param name="title">song title</param>
		/// <param name="copyrightInfo">copyright information</param>
		/// <param name="text">song text</param>
		public SongValidator(string title, string copyrightInfo, string text)
		{
			this.title = title;
			this.copyrightInfo = copyrightInfo;
			this.text = text;
			InitTextLines();
		}

		#endregion constructors

		#region public methods

		/// <summary>
		/// Validates the song
		/// </summary>
		/// <param name="errorMessage">error message, if not successful</param>
		/// <returns>true, if validation finished without errors</returns>
		public bool Validate(out string errorMessage)
		{
			if (!InitTextLines())
			{
				errorMessage = "Interner Fehler beim Prüfen des Liedtextes";
				return false;
			}

			StringBuilder sb = new StringBuilder();
			bool isValid = true;

			isValid &= CheckEmptyFields(sb);
			isValid &= CheckText(sb);

			errorMessage = sb.ToString();

			return isValid;
		}

		#endregion public methods

		#region private methods

		/// <summary>
		/// Initializes an internally used list of text lines to avoid unnecessary parsing
		/// </summary>
		/// <returns>true, if successful</returns>
		private bool InitTextLines()
		{
			try
			{
				textLines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).Select(x => x.Trim()).ToList();

				return true;
			}
			catch (Exception e)
			{
				Log.Error(e, "SongTextValidator.InitTextLines(): error initializing text lines for text {text}", text);

				textLines = new List<string>();

				return false;
			}
		}

		/// <summary>
		/// Checks for mandatory fields which are empty
		/// </summary>
		/// <param name="sb">string builder for validation errors</param>
		/// <returns>true, if validation finished without errors</returns>
		private bool CheckEmptyFields(StringBuilder sb)
		{
			bool isValid = true;

			if (string.IsNullOrWhiteSpace(title))
			{
				isValid = false;
				sb.AppendLine("Liedtitel darf nicht leer sein");
			}

			if (string.IsNullOrWhiteSpace(copyrightInfo))
			{
				isValid = false;
				sb.AppendLine("Copyright-Informationen dürfen nicht leer sein");
			}

			if (string.IsNullOrWhiteSpace(text))
			{
				isValid = false;
				sb.AppendLine("Liedtext darf nicht leer sein");
			}

			return isValid;
		}

		/// <summary>
		/// Checks the song text
		/// </summary>
		/// <param name="sb">string builder for validation errors</param>
		/// <returns>true, if validation finished without errors</returns>
		private bool CheckText(StringBuilder sb)
		{
			bool isValid = true;

			isValid &= CheckTextNumberOfLinesPerBlock(sb);
			isValid &= CheckTextBlankSlides(sb);

			return isValid;
		}

		/// <summary>
		/// Checks the number of text lines per block.
		/// Each slide has a fixed maximum number of text lines.
		/// </summary>
		/// <param name="sb">string builder for validation errors</param>
		/// <returns>true, if validation finished without errors</returns>
		private bool CheckTextNumberOfLinesPerBlock(StringBuilder sb)
		{
			bool isValid = true;

			int linesPerSlide = 0;
			for (int i = 0; i < textLines.Count; i++)
			{
				string line = textLines[i];

				if (string.IsNullOrWhiteSpace(line))
				{
					linesPerSlide = 0;
				}
				else
				{
					linesPerSlide++;
				}

				if (linesPerSlide > Constants.MaximumNumberOfTextLinesPerSlide)
				{
					isValid = false;
					sb.AppendLine($"Zeile {i}: Pro Folie sind maximal {Constants.MaximumNumberOfTextLinesPerSlide} Textzeilen erlaubt");
				}
			}

			return isValid;
		}

		/// <summary>
		/// Checks blank song parts.
		/// Placeholder for blank slides is only allowed on single lines (empty line before and after is needed).
		/// </summary>
		/// <param name="sb">string builder for validation errors</param>
		/// <returns>true, if validation finished without errors</returns>
		private bool CheckTextBlankSlides(StringBuilder sb)
		{
			bool isValid = true;

			for (int i = 0; i < textLines.Count; i++)
			{
				string line = textLines[i];
				if (line == Constants.BlankSlidePlaceholder)
				{
					string prevLine = (i > 0) ? textLines[i - 1] : "";
					string nextLine = (i < (textLines.Count - 1)) ? textLines[i + 1] : "";

					if (!string.IsNullOrWhiteSpace(prevLine) || !string.IsNullOrWhiteSpace(nextLine))
					{
						isValid = false;
						sb.AppendLine($"Zeile {i + 1}: Platzhalter für leere Folien muss von Leerzeilen eingeschlossen sein");
					}
				}
			}

			return isValid;
		}

		#endregion private methods
	}
}