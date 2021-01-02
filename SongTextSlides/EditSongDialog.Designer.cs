
namespace SongTextSlides
{
	partial class EditSongDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSongDialog));
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.TextBoxSongTitle = new System.Windows.Forms.TextBox();
			this.LabelSongTitle = new System.Windows.Forms.Label();
			this.TextBoxSongCopyright = new System.Windows.Forms.TextBox();
			this.LabelSongCopyright = new System.Windows.Forms.Label();
			this.TextBoxSongText = new System.Windows.Forms.TextBox();
			this.LabelSongText = new System.Windows.Forms.Label();
			this.ButtonOk = new System.Windows.Forms.Button();
			this.TextBoxCCLISongNumber = new System.Windows.Forms.TextBox();
			this.LabelCCLISongNumber = new System.Windows.Forms.Label();
			this.TextBoxCCLILicenseNumber = new System.Windows.Forms.TextBox();
			this.LabelCCLILicenseNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonCancel.Location = new System.Drawing.Point(528, 570);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 6;
			this.ButtonCancel.Text = "Abbrechen";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// TextBoxSongTitle
			// 
			this.TextBoxSongTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSongTitle.Location = new System.Drawing.Point(15, 29);
			this.TextBoxSongTitle.Name = "TextBoxSongTitle";
			this.TextBoxSongTitle.Size = new System.Drawing.Size(588, 23);
			this.TextBoxSongTitle.TabIndex = 0;
			// 
			// LabelSongTitle
			// 
			this.LabelSongTitle.AutoSize = true;
			this.LabelSongTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelSongTitle.Location = new System.Drawing.Point(12, 9);
			this.LabelSongTitle.Name = "LabelSongTitle";
			this.LabelSongTitle.Size = new System.Drawing.Size(56, 17);
			this.LabelSongTitle.TabIndex = 2;
			this.LabelSongTitle.Text = "Liedtitel:";
			// 
			// TextBoxSongCopyright
			// 
			this.TextBoxSongCopyright.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSongCopyright.Location = new System.Drawing.Point(15, 85);
			this.TextBoxSongCopyright.Multiline = true;
			this.TextBoxSongCopyright.Name = "TextBoxSongCopyright";
			this.TextBoxSongCopyright.Size = new System.Drawing.Size(588, 71);
			this.TextBoxSongCopyright.TabIndex = 1;
			// 
			// LabelSongCopyright
			// 
			this.LabelSongCopyright.AutoSize = true;
			this.LabelSongCopyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelSongCopyright.Location = new System.Drawing.Point(12, 65);
			this.LabelSongCopyright.Name = "LabelSongCopyright";
			this.LabelSongCopyright.Size = new System.Drawing.Size(154, 17);
			this.LabelSongCopyright.TabIndex = 4;
			this.LabelSongCopyright.Text = "Copyright-Informationen:";
			// 
			// TextBoxSongText
			// 
			this.TextBoxSongText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSongText.Location = new System.Drawing.Point(15, 223);
			this.TextBoxSongText.Multiline = true;
			this.TextBoxSongText.Name = "TextBoxSongText";
			this.TextBoxSongText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxSongText.Size = new System.Drawing.Size(588, 336);
			this.TextBoxSongText.TabIndex = 4;
			// 
			// LabelSongText
			// 
			this.LabelSongText.AutoSize = true;
			this.LabelSongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelSongText.Location = new System.Drawing.Point(12, 203);
			this.LabelSongText.Name = "LabelSongText";
			this.LabelSongText.Size = new System.Drawing.Size(56, 17);
			this.LabelSongText.TabIndex = 6;
			this.LabelSongText.Text = "Liedtext:";
			// 
			// ButtonOk
			// 
			this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonOk.Location = new System.Drawing.Point(414, 570);
			this.ButtonOk.Name = "ButtonOk";
			this.ButtonOk.Size = new System.Drawing.Size(108, 23);
			this.ButtonOk.TabIndex = 5;
			this.ButtonOk.Text = "Folien einfügen";
			this.ButtonOk.UseVisualStyleBackColor = true;
			this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
			// 
			// TextBoxCCLISongNumber
			// 
			this.TextBoxCCLISongNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxCCLISongNumber.Location = new System.Drawing.Point(129, 168);
			this.TextBoxCCLISongNumber.Name = "TextBoxCCLISongNumber";
			this.TextBoxCCLISongNumber.Size = new System.Drawing.Size(164, 23);
			this.TextBoxCCLISongNumber.TabIndex = 2;
			// 
			// LabelCCLISongNumber
			// 
			this.LabelCCLISongNumber.AutoSize = true;
			this.LabelCCLISongNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelCCLISongNumber.Location = new System.Drawing.Point(12, 170);
			this.LabelCCLISongNumber.Name = "LabelCCLISongNumber";
			this.LabelCCLISongNumber.Size = new System.Drawing.Size(113, 17);
			this.LabelCCLISongNumber.TabIndex = 8;
			this.LabelCCLISongNumber.Text = "CCLI-Liednummer:";
			// 
			// TextBoxCCLILicenseNumber
			// 
			this.TextBoxCCLILicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxCCLILicenseNumber.Location = new System.Drawing.Point(439, 168);
			this.TextBoxCCLILicenseNumber.Name = "TextBoxCCLILicenseNumber";
			this.TextBoxCCLILicenseNumber.Size = new System.Drawing.Size(164, 23);
			this.TextBoxCCLILicenseNumber.TabIndex = 3;
			// 
			// LabelCCLILicenseNumber
			// 
			this.LabelCCLILicenseNumber.AutoSize = true;
			this.LabelCCLILicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelCCLILicenseNumber.Location = new System.Drawing.Point(316, 171);
			this.LabelCCLILicenseNumber.Name = "LabelCCLILicenseNumber";
			this.LabelCCLILicenseNumber.Size = new System.Drawing.Size(124, 17);
			this.LabelCCLILicenseNumber.TabIndex = 10;
			this.LabelCCLILicenseNumber.Text = "CCLI-Lizenznummer:";
			// 
			// EditSongDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.CancelButton = this.ButtonCancel;
			this.ClientSize = new System.Drawing.Size(617, 605);
			this.Controls.Add(this.TextBoxCCLILicenseNumber);
			this.Controls.Add(this.LabelCCLILicenseNumber);
			this.Controls.Add(this.TextBoxCCLISongNumber);
			this.Controls.Add(this.LabelCCLISongNumber);
			this.Controls.Add(this.ButtonOk);
			this.Controls.Add(this.TextBoxSongText);
			this.Controls.Add(this.LabelSongText);
			this.Controls.Add(this.TextBoxSongCopyright);
			this.Controls.Add(this.LabelSongCopyright);
			this.Controls.Add(this.TextBoxSongTitle);
			this.Controls.Add(this.LabelSongTitle);
			this.Controls.Add(this.ButtonCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditSongDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Neues Lied / Lied bearbeiten";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.TextBox TextBoxSongTitle;
		private System.Windows.Forms.Label LabelSongTitle;
		private System.Windows.Forms.TextBox TextBoxSongCopyright;
		private System.Windows.Forms.Label LabelSongCopyright;
		private System.Windows.Forms.TextBox TextBoxSongText;
		private System.Windows.Forms.Label LabelSongText;
		private System.Windows.Forms.Button ButtonOk;
		private System.Windows.Forms.TextBox TextBoxCCLISongNumber;
		private System.Windows.Forms.Label LabelCCLISongNumber;
		private System.Windows.Forms.TextBox TextBoxCCLILicenseNumber;
		private System.Windows.Forms.Label LabelCCLILicenseNumber;
	}
}