namespace BinanceApp.WinForm
{
	partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.TxtLog = new System.Windows.Forms.TextBox();
			this.BtnAnalyze = new System.Windows.Forms.Button();
			this.TxtSymbol = new System.Windows.Forms.TextBox();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.MnuProgram = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuAnalyze = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuGetPrices = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuClearConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuProgramSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuProgramSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuSettingsSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// TxtLog
			// 
			this.TxtLog.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtLog.Location = new System.Drawing.Point(12, 83);
			this.TxtLog.Multiline = true;
			this.TxtLog.Name = "TxtLog";
			this.TxtLog.ReadOnly = true;
			this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TxtLog.Size = new System.Drawing.Size(524, 447);
			this.TxtLog.TabIndex = 0;
			// 
			// BtnAnalyze
			// 
			this.BtnAnalyze.Location = new System.Drawing.Point(13, 39);
			this.BtnAnalyze.Name = "BtnAnalyze";
			this.BtnAnalyze.Size = new System.Drawing.Size(174, 27);
			this.BtnAnalyze.TabIndex = 1;
			this.BtnAnalyze.Text = "Analiz et";
			this.BtnAnalyze.UseVisualStyleBackColor = true;
			this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
			// 
			// TxtSymbol
			// 
			this.TxtSymbol.Location = new System.Drawing.Point(193, 39);
			this.TxtSymbol.Name = "TxtSymbol";
			this.TxtSymbol.Size = new System.Drawing.Size(343, 27);
			this.TxtSymbol.TabIndex = 2;
			this.TxtSymbol.Text = "ETHBTC";
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.MnuProgram,
			this.MnuSettings});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(549, 24);
			this.MenuStrip.TabIndex = 3;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// MnuProgram
			// 
			this.MnuProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.MnuAnalyze,
			this.MnuGetPrices,
			this.MnuClearConsole,
			this.MnuProgramSeparator,
			this.MnuExit});
			this.MnuProgram.Name = "MnuProgram";
			this.MnuProgram.Size = new System.Drawing.Size(65, 20);
			this.MnuProgram.Text = "Program";
			// 
			// MnuAnalyze
			// 
			this.MnuAnalyze.Name = "MnuAnalyze";
			this.MnuAnalyze.Size = new System.Drawing.Size(158, 22);
			this.MnuAnalyze.Text = "Analiz et";
			this.MnuAnalyze.Click += new System.EventHandler(this.MnuAnalyze_Click);
			// 
			// MnuGetPrices
			// 
			this.MnuGetPrices.Name = "MnuGetPrices";
			this.MnuGetPrices.Size = new System.Drawing.Size(158, 22);
			this.MnuGetPrices.Text = "Fiyatları getir";
			this.MnuGetPrices.Click += new System.EventHandler(this.MnuGetPrices_Click);
			// 
			// MnuClearConsole
			// 
			this.MnuClearConsole.Name = "MnuClearConsole";
			this.MnuClearConsole.Size = new System.Drawing.Size(158, 22);
			this.MnuClearConsole.Text = "Konsolu temizle";
			this.MnuClearConsole.Click += new System.EventHandler(this.MnuClearConsole_Click);
			// 
			// MnuProgramSeparator
			// 
			this.MnuProgramSeparator.Name = "MnuProgramSeparator";
			this.MnuProgramSeparator.Size = new System.Drawing.Size(155, 6);
			// 
			// MnuExit
			// 
			this.MnuExit.Name = "MnuExit";
			this.MnuExit.Size = new System.Drawing.Size(158, 22);
			this.MnuExit.Text = "Çıkış";
			this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
			// 
			// MnuSettings
			// 
			this.MnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.MnuProgramSettings,
			this.MnuSettingsSeparator,
			this.MnuAbout});
			this.MnuSettings.Name = "MnuSettings";
			this.MnuSettings.Size = new System.Drawing.Size(56, 20);
			this.MnuSettings.Text = "Ayarlar";
			// 
			// MnuProgramSettings
			// 
			this.MnuProgramSettings.Name = "MnuProgramSettings";
			this.MnuProgramSettings.Size = new System.Drawing.Size(161, 22);
			this.MnuProgramSettings.Text = "Program ayarları";
			this.MnuProgramSettings.Click += new System.EventHandler(this.MnuProgramSettings_Click);
			// 
			// MnuSettingsSeparator
			// 
			this.MnuSettingsSeparator.Name = "MnuSettingsSeparator";
			this.MnuSettingsSeparator.Size = new System.Drawing.Size(158, 6);
			// 
			// MnuAbout
			// 
			this.MnuAbout.Name = "MnuAbout";
			this.MnuAbout.Size = new System.Drawing.Size(161, 22);
			this.MnuAbout.Text = "Hakkında";
			this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
			// 
			// StatusStrip
			// 
			this.StatusStrip.Location = new System.Drawing.Point(0, 542);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(549, 22);
			this.StatusStrip.TabIndex = 4;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 564);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.TxtSymbol);
			this.Controls.Add(this.BtnAnalyze);
			this.Controls.Add(this.TxtLog);
			this.Controls.Add(this.MenuStrip);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(564, 603);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Binance";
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtLog;
		private System.Windows.Forms.Button BtnAnalyze;
		private System.Windows.Forms.TextBox TxtSymbol;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.ToolStripMenuItem MnuProgram;
		private System.Windows.Forms.ToolStripMenuItem MnuSettings;
		private System.Windows.Forms.ToolStripMenuItem MnuAnalyze;
		private System.Windows.Forms.ToolStripMenuItem MnuExit;
		private System.Windows.Forms.ToolStripMenuItem MnuProgramSettings;
		private System.Windows.Forms.ToolStripSeparator MnuSettingsSeparator;
		private System.Windows.Forms.ToolStripMenuItem MnuAbout;
		private System.Windows.Forms.ToolStripMenuItem MnuClearConsole;
		private System.Windows.Forms.ToolStripSeparator MnuProgramSeparator;
		private System.Windows.Forms.ToolStripMenuItem MnuGetPrices;
	}
}

