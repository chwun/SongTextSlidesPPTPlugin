using System.Diagnostics;
using System.Windows.Forms;

namespace SongTextSlides
{
	/// <summary>
	/// Dialog class for information
	/// </summary>
	public partial class InfoDialog : Form
	{
		/// <summary>
		/// Creates a new instance of <see cref="InfoDialog"/>
		/// </summary>
		public InfoDialog()
		{
			InitializeComponent();

			LabelTitle.Text = PluginInfo.Title;
			LabelDescription.Text = PluginInfo.Description;
			LabelVersion.Text = "Version: " + PluginInfo.Version;
			LabelCopyright.Text = PluginInfo.Copyright;
			LinkLabelWeb.Text = PluginInfo.WebUrl;
		}

		/// <summary>
		/// Event handler for link label click (web url)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LinkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(PluginInfo.WebUrl);
		}
	}
}