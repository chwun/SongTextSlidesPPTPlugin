
namespace SongTextSlides
{
	partial class SettingsDialog
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
			this.ButtonOk = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.LabelSongFilesDirectory = new System.Windows.Forms.Label();
			this.TextBoxSongFilesDirectory = new System.Windows.Forms.TextBox();
			this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.ButtonChangeSongFilesDirectory = new System.Windows.Forms.Button();
			this.LabelCCLILicenseNumber = new System.Windows.Forms.Label();
			this.TextBoxCCLILicenseNumber = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ButtonOk
			// 
			this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonOk.Location = new System.Drawing.Point(552, 93);
			this.ButtonOk.Name = "ButtonOk";
			this.ButtonOk.Size = new System.Drawing.Size(75, 23);
			this.ButtonOk.TabIndex = 7;
			this.ButtonOk.Text = "OK";
			this.ButtonOk.UseVisualStyleBackColor = true;
			this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonCancel.Location = new System.Drawing.Point(643, 93);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 8;
			this.ButtonCancel.Text = "Abbrechen";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// LabelSongFilesDirectory
			// 
			this.LabelSongFilesDirectory.AutoSize = true;
			this.LabelSongFilesDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelSongFilesDirectory.Location = new System.Drawing.Point(12, 17);
			this.LabelSongFilesDirectory.Name = "LabelSongFilesDirectory";
			this.LabelSongFilesDirectory.Size = new System.Drawing.Size(214, 17);
			this.LabelSongFilesDirectory.TabIndex = 10;
			this.LabelSongFilesDirectory.Text = "Verzeichnis für gespeicherte Lieder:";
			// 
			// TextBoxSongFilesDirectory
			// 
			this.TextBoxSongFilesDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSongFilesDirectory.Location = new System.Drawing.Point(232, 14);
			this.TextBoxSongFilesDirectory.Name = "TextBoxSongFilesDirectory";
			this.TextBoxSongFilesDirectory.ReadOnly = true;
			this.TextBoxSongFilesDirectory.Size = new System.Drawing.Size(431, 23);
			this.TextBoxSongFilesDirectory.TabIndex = 11;
			this.TextBoxSongFilesDirectory.TabStop = false;
			this.TextBoxSongFilesDirectory.Text = "Directory xyz";
			this.TextBoxSongFilesDirectory.DoubleClick += new System.EventHandler(this.TextBoxSongFilesDirectory_DoubleClick);
			// 
			// ButtonChangeSongFilesDirectory
			// 
			this.ButtonChangeSongFilesDirectory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonChangeSongFilesDirectory.Location = new System.Drawing.Point(666, 14);
			this.ButtonChangeSongFilesDirectory.Name = "ButtonChangeSongFilesDirectory";
			this.ButtonChangeSongFilesDirectory.Size = new System.Drawing.Size(58, 23);
			this.ButtonChangeSongFilesDirectory.TabIndex = 12;
			this.ButtonChangeSongFilesDirectory.Text = "Ändern";
			this.ButtonChangeSongFilesDirectory.UseVisualStyleBackColor = true;
			this.ButtonChangeSongFilesDirectory.Click += new System.EventHandler(this.ButtonChangeSongFilesDirectory_Click);
			// 
			// LabelCCLILicenseNumber
			// 
			this.LabelCCLILicenseNumber.AutoSize = true;
			this.LabelCCLILicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelCCLILicenseNumber.Location = new System.Drawing.Point(12, 57);
			this.LabelCCLILicenseNumber.Name = "LabelCCLILicenseNumber";
			this.LabelCCLILicenseNumber.Size = new System.Drawing.Size(124, 17);
			this.LabelCCLILicenseNumber.TabIndex = 13;
			this.LabelCCLILicenseNumber.Text = "CCLI-Lizenznummer:";
			// 
			// TextBoxCCLILicenseNumber
			// 
			this.TextBoxCCLILicenseNumber.AcceptsTab = true;
			this.TextBoxCCLILicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxCCLILicenseNumber.Location = new System.Drawing.Point(232, 54);
			this.TextBoxCCLILicenseNumber.Name = "TextBoxCCLILicenseNumber";
			this.TextBoxCCLILicenseNumber.Size = new System.Drawing.Size(145, 23);
			this.TextBoxCCLILicenseNumber.TabIndex = 14;
			// 
			// SettingsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(735, 124);
			this.Controls.Add(this.TextBoxCCLILicenseNumber);
			this.Controls.Add(this.LabelCCLILicenseNumber);
			this.Controls.Add(this.ButtonChangeSongFilesDirectory);
			this.Controls.Add(this.TextBoxSongFilesDirectory);
			this.Controls.Add(this.LabelSongFilesDirectory);
			this.Controls.Add(this.ButtonOk);
			this.Controls.Add(this.ButtonCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Einstellungen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonOk;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Label LabelSongFilesDirectory;
		private System.Windows.Forms.TextBox TextBoxSongFilesDirectory;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
		private System.Windows.Forms.Button ButtonChangeSongFilesDirectory;
		private System.Windows.Forms.Label LabelCCLILicenseNumber;
		private System.Windows.Forms.TextBox TextBoxCCLILicenseNumber;
	}
}