
namespace SongTextSlides
{
	partial class SongTextSlidesRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public SongTextSlidesRibbon()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongTextSlidesRibbon));
			this.tab1 = this.Factory.CreateRibbonTab();
			this.tab2 = this.Factory.CreateRibbonTab();
			this.group1 = this.Factory.CreateRibbonGroup();
			this.ButtonNewSong = this.Factory.CreateRibbonButton();
			this.ButtonSelectSong = this.Factory.CreateRibbonButton();
			this.group3 = this.Factory.CreateRibbonGroup();
			this.ButtonSettings = this.Factory.CreateRibbonButton();
			this.group2 = this.Factory.CreateRibbonGroup();
			this.ButtonHelp = this.Factory.CreateRibbonButton();
			this.ButtonInfo = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.tab2.SuspendLayout();
			this.group1.SuspendLayout();
			this.group3.SuspendLayout();
			this.group2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Label = "TabAddIns";
			this.tab1.Name = "tab1";
			// 
			// tab2
			// 
			this.tab2.Groups.Add(this.group1);
			this.tab2.Groups.Add(this.group3);
			this.tab2.Groups.Add(this.group2);
			this.tab2.Label = "Liedtexte";
			this.tab2.Name = "tab2";
			// 
			// group1
			// 
			this.group1.Items.Add(this.ButtonNewSong);
			this.group1.Items.Add(this.ButtonSelectSong);
			this.group1.Label = "Liedtext";
			this.group1.Name = "group1";
			// 
			// ButtonNewSong
			// 
			this.ButtonNewSong.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.ButtonNewSong.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewSong.Image")));
			this.ButtonNewSong.Label = "Neues Lied";
			this.ButtonNewSong.Name = "ButtonNewSong";
			this.ButtonNewSong.ScreenTip = "Neues Lied hinzufügen";
			this.ButtonNewSong.ShowImage = true;
			this.ButtonNewSong.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonNewSong_Click);
			// 
			// ButtonSelectSong
			// 
			this.ButtonSelectSong.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.ButtonSelectSong.Enabled = false;
			this.ButtonSelectSong.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSelectSong.Image")));
			this.ButtonSelectSong.Label = "Lied auswählen";
			this.ButtonSelectSong.Name = "ButtonSelectSong";
			this.ButtonSelectSong.ScreenTip = "Bestehendes Lied aus Liste auswählen";
			this.ButtonSelectSong.ShowImage = true;
			this.ButtonSelectSong.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonSelectSong_Click);
			// 
			// group3
			// 
			this.group3.Items.Add(this.ButtonSettings);
			this.group3.Name = "group3";
			// 
			// ButtonSettings
			// 
			this.ButtonSettings.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.ButtonSettings.Enabled = false;
			this.ButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSettings.Image")));
			this.ButtonSettings.Label = "Einstellungen";
			this.ButtonSettings.Name = "ButtonSettings";
			this.ButtonSettings.ShowImage = true;
			// 
			// group2
			// 
			this.group2.Items.Add(this.ButtonHelp);
			this.group2.Items.Add(this.ButtonInfo);
			this.group2.Name = "group2";
			// 
			// ButtonHelp
			// 
			this.ButtonHelp.Enabled = false;
			this.ButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHelp.Image")));
			this.ButtonHelp.Label = "Hilfe";
			this.ButtonHelp.Name = "ButtonHelp";
			this.ButtonHelp.ShowImage = true;
			// 
			// ButtonInfo
			// 
			this.ButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonInfo.Image")));
			this.ButtonInfo.Label = "Info";
			this.ButtonInfo.Name = "ButtonInfo";
			this.ButtonInfo.ShowImage = true;
			this.ButtonInfo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonInfo_Click);
			// 
			// SongTextSlidesRibbon
			// 
			this.Name = "SongTextSlidesRibbon";
			this.RibbonType = "Microsoft.PowerPoint.Presentation";
			this.Tabs.Add(this.tab1);
			this.Tabs.Add(this.tab2);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SongTextSlidesRibbon_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.tab2.ResumeLayout(false);
			this.tab2.PerformLayout();
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();
			this.group3.ResumeLayout(false);
			this.group3.PerformLayout();
			this.group2.ResumeLayout(false);
			this.group2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		private Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonNewSong;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonSelectSong;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonInfo;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonHelp;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonSettings;
	}

	partial class ThisRibbonCollection
	{
		internal SongTextSlidesRibbon SongTextSlidesRibbon
		{
			get { return this.GetRibbon<SongTextSlidesRibbon>(); }
		}
	}
}
