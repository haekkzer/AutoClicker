
namespace AutoClicker
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.ButtonEnable = new System.Windows.Forms.Button();
			this.ButtonDisable = new System.Windows.Forms.Button();
			this.TrackBarCPS = new System.Windows.Forms.TrackBar();
			this.PictureBoxIndicator = new System.Windows.Forms.PictureBox();
			this.CheckBoxAOT = new System.Windows.Forms.CheckBox();
			this.TimerClick = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.CheckBoxMp = new System.Windows.Forms.CheckBox();
			this.TrackBarMp = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.CheckBoxHk = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.TrackBarCPS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxIndicator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrackBarMp)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonEnable
			// 
			this.ButtonEnable.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonEnable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ButtonEnable.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonEnable.Location = new System.Drawing.Point(9, 9);
			this.ButtonEnable.Margin = new System.Windows.Forms.Padding(2);
			this.ButtonEnable.Name = "ButtonEnable";
			this.ButtonEnable.Size = new System.Drawing.Size(71, 27);
			this.ButtonEnable.TabIndex = 0;
			this.ButtonEnable.Text = "Enable";
			this.ButtonEnable.UseVisualStyleBackColor = true;
			this.ButtonEnable.Click += new System.EventHandler(this.ButtonEnable_Click);
			// 
			// ButtonDisable
			// 
			this.ButtonDisable.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonDisable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ButtonDisable.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDisable.Location = new System.Drawing.Point(9, 40);
			this.ButtonDisable.Margin = new System.Windows.Forms.Padding(2);
			this.ButtonDisable.Name = "ButtonDisable";
			this.ButtonDisable.Size = new System.Drawing.Size(71, 27);
			this.ButtonDisable.TabIndex = 1;
			this.ButtonDisable.Text = "Disable";
			this.ButtonDisable.UseVisualStyleBackColor = true;
			this.ButtonDisable.Click += new System.EventHandler(this.ButtonDisable_Click);
			// 
			// TrackBarCPS
			// 
			this.TrackBarCPS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.TrackBarCPS.LargeChange = 100;
			this.TrackBarCPS.Location = new System.Drawing.Point(9, 80);
			this.TrackBarCPS.Margin = new System.Windows.Forms.Padding(2);
			this.TrackBarCPS.Maximum = 240;
			this.TrackBarCPS.Minimum = 10;
			this.TrackBarCPS.Name = "TrackBarCPS";
			this.TrackBarCPS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.TrackBarCPS.Size = new System.Drawing.Size(257, 45);
			this.TrackBarCPS.SmallChange = 5;
			this.TrackBarCPS.TabIndex = 2;
			this.TrackBarCPS.Value = 120;
			this.TrackBarCPS.Scroll += new System.EventHandler(this.TrackBarCPS_Scroll);
			this.TrackBarCPS.Enter += new System.EventHandler(this.TrackBarCPS_Enter);
			// 
			// PictureBoxIndicator
			// 
			this.PictureBoxIndicator.Image = global::AutoClicker.Properties.Resources.Indicator_RED;
			this.PictureBoxIndicator.Location = new System.Drawing.Point(90, 9);
			this.PictureBoxIndicator.Margin = new System.Windows.Forms.Padding(2);
			this.PictureBoxIndicator.Name = "PictureBoxIndicator";
			this.PictureBoxIndicator.Size = new System.Drawing.Size(42, 58);
			this.PictureBoxIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxIndicator.TabIndex = 3;
			this.PictureBoxIndicator.TabStop = false;
			// 
			// CheckBoxAOT
			// 
			this.CheckBoxAOT.AutoSize = true;
			this.CheckBoxAOT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CheckBoxAOT.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CheckBoxAOT.Location = new System.Drawing.Point(148, 14);
			this.CheckBoxAOT.Name = "CheckBoxAOT";
			this.CheckBoxAOT.Size = new System.Drawing.Size(117, 19);
			this.CheckBoxAOT.TabIndex = 4;
			this.CheckBoxAOT.Text = "Always on Top";
			this.CheckBoxAOT.UseVisualStyleBackColor = true;
			this.CheckBoxAOT.CheckedChanged += new System.EventHandler(this.CheckBoxAlwaysOnTop_Changed);
			// 
			// TimerClick
			// 
			this.TimerClick.Tick += new System.EventHandler(this.TimerClick_Tick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "~4 C/S";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(210, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "~64 C/S";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(116, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "~8 C/S";
			// 
			// CheckBoxMp
			// 
			this.CheckBoxMp.AutoSize = true;
			this.CheckBoxMp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CheckBoxMp.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CheckBoxMp.Location = new System.Drawing.Point(9, 141);
			this.CheckBoxMp.Name = "CheckBoxMp";
			this.CheckBoxMp.Size = new System.Drawing.Size(145, 19);
			this.CheckBoxMp.TabIndex = 10;
			this.CheckBoxMp.Text = "Enable Multiplier";
			this.CheckBoxMp.UseVisualStyleBackColor = true;
			this.CheckBoxMp.CheckedChanged += new System.EventHandler(this.CheckBoxMultiplier_Changed);
			// 
			// TrackBarMp
			// 
			this.TrackBarMp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.TrackBarMp.Enabled = false;
			this.TrackBarMp.LargeChange = 1;
			this.TrackBarMp.Location = new System.Drawing.Point(9, 165);
			this.TrackBarMp.Margin = new System.Windows.Forms.Padding(2);
			this.TrackBarMp.Maximum = 4;
			this.TrackBarMp.Minimum = 1;
			this.TrackBarMp.Name = "TrackBarMp";
			this.TrackBarMp.Size = new System.Drawing.Size(257, 45);
			this.TrackBarMp.TabIndex = 11;
			this.TrackBarMp.Value = 1;
			this.TrackBarMp.Enter += new System.EventHandler(this.TrackBarMp_Enter);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "x1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(245, 197);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(21, 15);
			this.label7.TabIndex = 13;
			this.label7.Text = "x4";
			// 
			// CheckBoxHk
			// 
			this.CheckBoxHk.AutoSize = true;
			this.CheckBoxHk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CheckBoxHk.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CheckBoxHk.Location = new System.Drawing.Point(148, 45);
			this.CheckBoxHk.Name = "CheckBoxHk";
			this.CheckBoxHk.Size = new System.Drawing.Size(110, 19);
			this.CheckBoxHk.TabIndex = 14;
			this.CheckBoxHk.Text = "CTRL+SHIFT+T";
			this.CheckBoxHk.UseVisualStyleBackColor = true;
			this.CheckBoxHk.CheckedChanged += new System.EventHandler(this.CheckBoxHotkey_Changed);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 221);
			this.Controls.Add(this.CheckBoxHk);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TrackBarMp);
			this.Controls.Add(this.CheckBoxMp);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CheckBoxAOT);
			this.Controls.Add(this.PictureBoxIndicator);
			this.Controls.Add(this.TrackBarCPS);
			this.Controls.Add(this.ButtonDisable);
			this.Controls.Add(this.ButtonEnable);
			this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "Auto Clicker";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.TrackBarCPS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxIndicator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrackBarMp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEnable;
        private System.Windows.Forms.Button ButtonDisable;
        private System.Windows.Forms.TrackBar TrackBarCPS;
        private System.Windows.Forms.PictureBox PictureBoxIndicator;
        private System.Windows.Forms.CheckBox CheckBoxAOT;
        private System.Windows.Forms.Timer TimerClick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBoxMp;
        private System.Windows.Forms.TrackBar TrackBarMp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox CheckBoxHk;
	}
}

