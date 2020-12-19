using Microsoft.Office.Tools.Ribbon;

namespace SongTextSlides
{
	public partial class SongTextSlidesRibbon
	{
		private void SongTextSlidesRibbon_Load(object sender, RibbonUIEventArgs e)
		{
		}

		private void ButtonNewSong_Click(object sender, RibbonControlEventArgs e)
		{
			EditSongDialog newSongDialog = new EditSongDialog(null);
			newSongDialog.ShowDialog();
		}

		private void ButtonSelectSong_Click(object sender, RibbonControlEventArgs e)
		{
		}

		private void ButtonInfo_Click(object sender, RibbonControlEventArgs e)
		{
			InfoDialog infoDialog = new InfoDialog();
			infoDialog.ShowDialog();
		}
	}
}