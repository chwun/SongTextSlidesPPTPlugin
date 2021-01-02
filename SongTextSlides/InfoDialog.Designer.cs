
namespace SongTextSlides
{
	partial class InfoDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDialog));
			this.ButtonOk = new System.Windows.Forms.Button();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.LabelDescription = new System.Windows.Forms.Label();
			this.LabelCopyright = new System.Windows.Forms.Label();
			this.LinkLabelWeb = new System.Windows.Forms.LinkLabel();
			this.LabelVersion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonOk
			// 
			this.ButtonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonOk.Location = new System.Drawing.Point(261, 141);
			this.ButtonOk.Name = "ButtonOk";
			this.ButtonOk.Size = new System.Drawing.Size(75, 23);
			this.ButtonOk.TabIndex = 4;
			this.ButtonOk.Text = "OK";
			this.ButtonOk.UseVisualStyleBackColor = true;
			// 
			// LabelTitle
			// 
			this.LabelTitle.AutoSize = true;
			this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTitle.Location = new System.Drawing.Point(23, 9);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(44, 21);
			this.LabelTitle.TabIndex = 5;
			this.LabelTitle.Text = "Title";
			// 
			// LabelDescription
			// 
			this.LabelDescription.AutoSize = true;
			this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelDescription.Location = new System.Drawing.Point(24, 30);
			this.LabelDescription.Name = "LabelDescription";
			this.LabelDescription.Size = new System.Drawing.Size(68, 17);
			this.LabelDescription.TabIndex = 6;
			this.LabelDescription.Text = "description";
			// 
			// LabelCopyright
			// 
			this.LabelCopyright.AutoSize = true;
			this.LabelCopyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelCopyright.Location = new System.Drawing.Point(24, 87);
			this.LabelCopyright.Name = "LabelCopyright";
			this.LabelCopyright.Size = new System.Drawing.Size(65, 17);
			this.LabelCopyright.TabIndex = 7;
			this.LabelCopyright.Text = "Copyright";
			// 
			// LinkLabelWeb
			// 
			this.LinkLabelWeb.AutoSize = true;
			this.LinkLabelWeb.LinkColor = System.Drawing.Color.DarkGreen;
			this.LinkLabelWeb.Location = new System.Drawing.Point(24, 107);
			this.LinkLabelWeb.Name = "LinkLabelWeb";
			this.LinkLabelWeb.Size = new System.Drawing.Size(30, 13);
			this.LinkLabelWeb.TabIndex = 9;
			this.LinkLabelWeb.TabStop = true;
			this.LinkLabelWeb.Text = "Web";
			this.LinkLabelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelWeb_LinkClicked);
			// 
			// LabelVersion
			// 
			this.LabelVersion.AutoSize = true;
			this.LabelVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelVersion.Location = new System.Drawing.Point(24, 58);
			this.LabelVersion.Name = "LabelVersion";
			this.LabelVersion.Size = new System.Drawing.Size(51, 17);
			this.LabelVersion.TabIndex = 10;
			this.LabelVersion.Text = "Version";
			// 
			// InfoDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.CancelButton = this.ButtonOk;
			this.ClientSize = new System.Drawing.Size(352, 175);
			this.Controls.Add(this.LabelVersion);
			this.Controls.Add(this.LinkLabelWeb);
			this.Controls.Add(this.LabelCopyright);
			this.Controls.Add(this.LabelDescription);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.ButtonOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InfoDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonOk;
		private System.Windows.Forms.Label LabelTitle;
		private System.Windows.Forms.Label LabelDescription;
		private System.Windows.Forms.Label LabelCopyright;
		private System.Windows.Forms.LinkLabel LinkLabelWeb;
		private System.Windows.Forms.Label LabelVersion;
	}
}