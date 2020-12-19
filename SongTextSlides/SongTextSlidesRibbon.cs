using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongTextSlides
{
	public partial class SongTextSlidesRibbon
	{
		private void SongTextSlidesRibbon_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void ButtonNewSong_Click(object sender, RibbonControlEventArgs e)
		{
			EditSongDialog newSongDialog = new EditSongDialog(EditSongDialogMode.NewSong, null);
			newSongDialog.ShowDialog();
		}

		private void ButtonSelectSong_Click(object sender, RibbonControlEventArgs e)
		{

		}
	}
}
