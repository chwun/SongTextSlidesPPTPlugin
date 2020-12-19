using Serilog;
using SongTextSlides.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongTextSlides.Logic
{
	public class SongTextValidator
	{
		private readonly string title;
		private readonly string copyrightInfos;
		private readonly string text;
		private List<string> textLines;

		public SongTextValidator(string title, string copyrightInfos, string text)
		{
			this.title = title;
			this.copyrightInfos = copyrightInfos;
			this.text = text;
			InitTextLines();
		}

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

		private bool CheckEmptyFields(StringBuilder sb)
		{
			bool isValid = true;

			if (string.IsNullOrWhiteSpace(title))
			{
				isValid = false;
				sb.AppendLine("Liedtitel darf nicht leer sein");
			}

			if (string.IsNullOrWhiteSpace(copyrightInfos))
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

		private bool CheckText(StringBuilder sb)
		{
			bool isValid = true;

			isValid &= CheckTextNumberOfLinesPerSlide(sb);
			isValid &= CheckTextBlankSlides(sb);

			return isValid;
		}

		private bool CheckTextNumberOfLinesPerSlide(StringBuilder sb)
		{
			bool isValid = true;

			// each slide has a maximum number of text lines

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

		private bool CheckTextBlankSlides(StringBuilder sb)
		{
			bool isValid = true;

			// placeholder for blank slides is only allowed on single lines (empty line before and after is needed)

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
	}
}