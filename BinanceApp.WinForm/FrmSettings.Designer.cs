namespace BinanceApp.WinForm
{
	partial class FrmSettings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
			this.LblApiKey = new System.Windows.Forms.Label();
			this.TxtApiKey = new System.Windows.Forms.TextBox();
			this.LblApiSecret = new System.Windows.Forms.Label();
			this.TxtApiSecret = new System.Windows.Forms.TextBox();
			this.LblBinanceSettings = new System.Windows.Forms.Label();
			this.LblProgram = new System.Windows.Forms.Label();
			this.LblSymbol = new System.Windows.Forms.Label();
			this.TxtSymbol = new System.Windows.Forms.TextBox();
			this.LblInterval = new System.Windows.Forms.Label();
			this.TxtInterval = new System.Windows.Forms.TextBox();
			this.LblDatabase = new System.Windows.Forms.Label();
			this.LblDbAddress = new System.Windows.Forms.Label();
			this.TxtDbAddress = new System.Windows.Forms.TextBox();
			this.LblDbName = new System.Windows.Forms.Label();
			this.TxtDbName = new System.Windows.Forms.TextBox();
			this.LblDbUsername = new System.Windows.Forms.Label();
			this.TxtDbUsername = new System.Windows.Forms.TextBox();
			this.LblDbPassword = new System.Windows.Forms.Label();
			this.TxtDbPassword = new System.Windows.Forms.TextBox();
			this.BtnSave = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblApiKey
			// 
			this.LblApiKey.AutoSize = true;
			this.LblApiKey.Location = new System.Drawing.Point(13, 43);
			this.LblApiKey.Name = "LblApiKey";
			this.LblApiKey.Size = new System.Drawing.Size(57, 19);
			this.LblApiKey.TabIndex = 0;
			this.LblApiKey.Text = "Api Key";
			// 
			// TxtApiKey
			// 
			this.TxtApiKey.Location = new System.Drawing.Point(131, 41);
			this.TxtApiKey.Name = "TxtApiKey";
			this.TxtApiKey.Size = new System.Drawing.Size(281, 27);
			this.TxtApiKey.TabIndex = 1;
			// 
			// LblApiSecret
			// 
			this.LblApiSecret.AutoSize = true;
			this.LblApiSecret.Location = new System.Drawing.Point(13, 87);
			this.LblApiSecret.Name = "LblApiSecret";
			this.LblApiSecret.Size = new System.Drawing.Size(74, 19);
			this.LblApiSecret.TabIndex = 2;
			this.LblApiSecret.Text = "Api Secret";
			// 
			// TxtApiSecret
			// 
			this.TxtApiSecret.Location = new System.Drawing.Point(131, 84);
			this.TxtApiSecret.Name = "TxtApiSecret";
			this.TxtApiSecret.Size = new System.Drawing.Size(281, 27);
			this.TxtApiSecret.TabIndex = 3;
			// 
			// LblBinanceSettings
			// 
			this.LblBinanceSettings.AutoSize = true;
			this.LblBinanceSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblBinanceSettings.Location = new System.Drawing.Point(13, 9);
			this.LblBinanceSettings.Name = "LblBinanceSettings";
			this.LblBinanceSettings.Size = new System.Drawing.Size(119, 19);
			this.LblBinanceSettings.TabIndex = 4;
			this.LblBinanceSettings.Text = "Binance ayarları";
			// 
			// LblProgram
			// 
			this.LblProgram.AutoSize = true;
			this.LblProgram.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblProgram.Location = new System.Drawing.Point(13, 124);
			this.LblProgram.Name = "LblProgram";
			this.LblProgram.Size = new System.Drawing.Size(124, 19);
			this.LblProgram.TabIndex = 5;
			this.LblProgram.Text = "Program ayarları";
			// 
			// LblSymbol
			// 
			this.LblSymbol.AutoSize = true;
			this.LblSymbol.Location = new System.Drawing.Point(13, 160);
			this.LblSymbol.Name = "LblSymbol";
			this.LblSymbol.Size = new System.Drawing.Size(56, 19);
			this.LblSymbol.TabIndex = 6;
			this.LblSymbol.Text = "Sembol";
			// 
			// TxtSymbol
			// 
			this.TxtSymbol.Location = new System.Drawing.Point(131, 157);
			this.TxtSymbol.Name = "TxtSymbol";
			this.TxtSymbol.Size = new System.Drawing.Size(281, 27);
			this.TxtSymbol.TabIndex = 7;
			// 
			// LblInterval
			// 
			this.LblInterval.AutoSize = true;
			this.LblInterval.Location = new System.Drawing.Point(13, 200);
			this.LblInterval.Name = "LblInterval";
			this.LblInterval.Size = new System.Drawing.Size(58, 19);
			this.LblInterval.TabIndex = 8;
			this.LblInterval.Text = "Interval";
			// 
			// TxtInterval
			// 
			this.TxtInterval.Location = new System.Drawing.Point(131, 197);
			this.TxtInterval.Name = "TxtInterval";
			this.TxtInterval.Size = new System.Drawing.Size(281, 27);
			this.TxtInterval.TabIndex = 9;
			// 
			// LblDatabase
			// 
			this.LblDatabase.AutoSize = true;
			this.LblDatabase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblDatabase.Location = new System.Drawing.Point(13, 239);
			this.LblDatabase.Name = "LblDatabase";
			this.LblDatabase.Size = new System.Drawing.Size(135, 19);
			this.LblDatabase.TabIndex = 10;
			this.LblDatabase.Text = "Veritabanı ayarları";
			// 
			// LblDbAddress
			// 
			this.LblDbAddress.AutoSize = true;
			this.LblDbAddress.Location = new System.Drawing.Point(13, 279);
			this.LblDbAddress.Name = "LblDbAddress";
			this.LblDbAddress.Size = new System.Drawing.Size(50, 19);
			this.LblDbAddress.TabIndex = 11;
			this.LblDbAddress.Text = "Adresi";
			// 
			// TxtDbAddress
			// 
			this.TxtDbAddress.Location = new System.Drawing.Point(131, 276);
			this.TxtDbAddress.Name = "TxtDbAddress";
			this.TxtDbAddress.Size = new System.Drawing.Size(281, 27);
			this.TxtDbAddress.TabIndex = 12;
			// 
			// LblDbName
			// 
			this.LblDbName.AutoSize = true;
			this.LblDbName.Location = new System.Drawing.Point(13, 321);
			this.LblDbName.Name = "LblDbName";
			this.LblDbName.Size = new System.Drawing.Size(52, 19);
			this.LblDbName.TabIndex = 13;
			this.LblDbName.Text = "DB adı";
			// 
			// TxtDbName
			// 
			this.TxtDbName.Location = new System.Drawing.Point(131, 318);
			this.TxtDbName.Name = "TxtDbName";
			this.TxtDbName.Size = new System.Drawing.Size(281, 27);
			this.TxtDbName.TabIndex = 14;
			// 
			// LblDbUsername
			// 
			this.LblDbUsername.AutoSize = true;
			this.LblDbUsername.Location = new System.Drawing.Point(13, 361);
			this.LblDbUsername.Name = "LblDbUsername";
			this.LblDbUsername.Size = new System.Drawing.Size(96, 19);
			this.LblDbUsername.TabIndex = 15;
			this.LblDbUsername.Text = "DB username";
			// 
			// TxtDbUsername
			// 
			this.TxtDbUsername.Location = new System.Drawing.Point(131, 358);
			this.TxtDbUsername.Name = "TxtDbUsername";
			this.TxtDbUsername.Size = new System.Drawing.Size(281, 27);
			this.TxtDbUsername.TabIndex = 16;
			// 
			// LblDbPassword
			// 
			this.LblDbPassword.AutoSize = true;
			this.LblDbPassword.Location = new System.Drawing.Point(13, 404);
			this.LblDbPassword.Name = "LblDbPassword";
			this.LblDbPassword.Size = new System.Drawing.Size(94, 19);
			this.LblDbPassword.TabIndex = 17;
			this.LblDbPassword.Text = "DB password";
			// 
			// TxtDbPassword
			// 
			this.TxtDbPassword.Location = new System.Drawing.Point(131, 401);
			this.TxtDbPassword.Name = "TxtDbPassword";
			this.TxtDbPassword.Size = new System.Drawing.Size(281, 27);
			this.TxtDbPassword.TabIndex = 18;
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(289, 443);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(123, 36);
			this.BtnSave.TabIndex = 19;
			this.BtnSave.Text = "Kaydet";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Location = new System.Drawing.Point(131, 443);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(120, 36);
			this.BtnCancel.TabIndex = 20;
			this.BtnCancel.Text = "Vazgeç";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// FrmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 496);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.TxtDbPassword);
			this.Controls.Add(this.LblDbPassword);
			this.Controls.Add(this.TxtDbUsername);
			this.Controls.Add(this.LblDbUsername);
			this.Controls.Add(this.TxtDbName);
			this.Controls.Add(this.LblDbName);
			this.Controls.Add(this.TxtDbAddress);
			this.Controls.Add(this.LblDbAddress);
			this.Controls.Add(this.LblDatabase);
			this.Controls.Add(this.TxtInterval);
			this.Controls.Add(this.LblInterval);
			this.Controls.Add(this.TxtSymbol);
			this.Controls.Add(this.LblSymbol);
			this.Controls.Add(this.LblProgram);
			this.Controls.Add(this.LblBinanceSettings);
			this.Controls.Add(this.TxtApiSecret);
			this.Controls.Add(this.LblApiSecret);
			this.Controls.Add(this.TxtApiKey);
			this.Controls.Add(this.LblApiKey);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ayarlar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblApiKey;
		private System.Windows.Forms.TextBox TxtApiKey;
		private System.Windows.Forms.Label LblApiSecret;
		private System.Windows.Forms.TextBox TxtApiSecret;
		private System.Windows.Forms.Label LblBinanceSettings;
		private System.Windows.Forms.Label LblProgram;
		private System.Windows.Forms.Label LblSymbol;
		private System.Windows.Forms.TextBox TxtSymbol;
		private System.Windows.Forms.Label LblInterval;
		private System.Windows.Forms.TextBox TxtInterval;
		private System.Windows.Forms.Label LblDatabase;
		private System.Windows.Forms.Label LblDbAddress;
		private System.Windows.Forms.TextBox TxtDbAddress;
		private System.Windows.Forms.Label LblDbName;
		private System.Windows.Forms.TextBox TxtDbName;
		private System.Windows.Forms.Label LblDbUsername;
		private System.Windows.Forms.TextBox TxtDbUsername;
		private System.Windows.Forms.Label LblDbPassword;
		private System.Windows.Forms.TextBox TxtDbPassword;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Button BtnCancel;
	}
}