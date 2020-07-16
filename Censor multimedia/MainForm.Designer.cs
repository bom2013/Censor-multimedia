namespace Censor_multimedia
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.srcButton = new System.Windows.Forms.Button();
            this.srcTextBox = new System.Windows.Forms.TextBox();
            this.desTextBox = new System.Windows.Forms.TextBox();
            this.addCensorPartButton = new System.Windows.Forms.Button();
            this.exportM3u8Button = new System.Windows.Forms.Button();
            this.removeCensorPartButton = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.importButton = new System.Windows.Forms.Button();
            this.exportCnsButton = new System.Windows.Forms.Button();
            this.levelACheckBox = new System.Windows.Forms.CheckBox();
            this.levelBCheckBox = new System.Windows.Forms.CheckBox();
            this.levelCCheckBox = new System.Windows.Forms.CheckBox();
            this.CensorPartListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.RestoreDirectory = true;
            // 
            // srcButton
            // 
            this.srcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcButton.Location = new System.Drawing.Point(998, 12);
            this.srcButton.Name = "srcButton";
            this.srcButton.Size = new System.Drawing.Size(77, 28);
            this.srcButton.TabIndex = 0;
            this.srcButton.Text = "Browse";
            this.srcButton.UseVisualStyleBackColor = true;
            this.srcButton.Click += new System.EventHandler(this.SrcButton_Click);
            // 
            // srcTextBox
            // 
            this.srcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcTextBox.Location = new System.Drawing.Point(12, 14);
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.Size = new System.Drawing.Size(980, 26);
            this.srcTextBox.TabIndex = 2;
            this.srcTextBox.Leave += new System.EventHandler(this.SrcTextBox_Leave);
            // 
            // desTextBox
            // 
            this.desTextBox.Enabled = false;
            this.desTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desTextBox.Location = new System.Drawing.Point(12, 51);
            this.desTextBox.Name = "desTextBox";
            this.desTextBox.Size = new System.Drawing.Size(980, 26);
            this.desTextBox.TabIndex = 3;
            // 
            // addCensorPartButton
            // 
            this.addCensorPartButton.Enabled = false;
            this.addCensorPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCensorPartButton.Location = new System.Drawing.Point(332, 84);
            this.addCensorPartButton.Name = "addCensorPartButton";
            this.addCensorPartButton.Size = new System.Drawing.Size(114, 37);
            this.addCensorPartButton.TabIndex = 5;
            this.addCensorPartButton.Text = "Add";
            this.addCensorPartButton.UseVisualStyleBackColor = true;
            this.addCensorPartButton.Click += new System.EventHandler(this.AddCensorPartButton_Click);
            // 
            // exportM3u8Button
            // 
            this.exportM3u8Button.Enabled = false;
            this.exportM3u8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportM3u8Button.Location = new System.Drawing.Point(332, 369);
            this.exportM3u8Button.Name = "exportM3u8Button";
            this.exportM3u8Button.Size = new System.Drawing.Size(114, 62);
            this.exportM3u8Button.TabIndex = 6;
            this.exportM3u8Button.Text = "Export to .m3u8";
            this.exportM3u8Button.UseVisualStyleBackColor = true;
            this.exportM3u8Button.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // removeCensorPartButton
            // 
            this.removeCensorPartButton.Enabled = false;
            this.removeCensorPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCensorPartButton.Location = new System.Drawing.Point(332, 127);
            this.removeCensorPartButton.Name = "removeCensorPartButton";
            this.removeCensorPartButton.Size = new System.Drawing.Size(114, 37);
            this.removeCensorPartButton.TabIndex = 7;
            this.removeCensorPartButton.Text = "Remove";
            this.removeCensorPartButton.UseVisualStyleBackColor = true;
            this.removeCensorPartButton.Click += new System.EventHandler(this.RemoveCensorPartButton_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(452, 83);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(623, 349);
            this.WindowsMediaPlayer.TabIndex = 8;
            this.WindowsMediaPlayer.CurrentPlaylistChange += new AxWMPLib._WMPOCXEvents_CurrentPlaylistChangeEventHandler(this.WindowsMediaPlayer_CurrentPlaylistChange);
            // 
            // importButton
            // 
            this.importButton.Enabled = false;
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(332, 170);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(114, 37);
            this.importButton.TabIndex = 9;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // exportCnsButton
            // 
            this.exportCnsButton.Enabled = false;
            this.exportCnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportCnsButton.Location = new System.Drawing.Point(332, 301);
            this.exportCnsButton.Name = "exportCnsButton";
            this.exportCnsButton.Size = new System.Drawing.Size(114, 62);
            this.exportCnsButton.TabIndex = 10;
            this.exportCnsButton.Text = "Export to .cns";
            this.exportCnsButton.UseVisualStyleBackColor = true;
            this.exportCnsButton.Click += new System.EventHandler(this.ExportCnsButton_Click);
            // 
            // levelACheckBox
            // 
            this.levelACheckBox.AutoSize = true;
            this.levelACheckBox.Checked = true;
            this.levelACheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.levelACheckBox.Enabled = false;
            this.levelACheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelACheckBox.Location = new System.Drawing.Point(333, 214);
            this.levelACheckBox.Name = "levelACheckBox";
            this.levelACheckBox.Size = new System.Drawing.Size(80, 24);
            this.levelACheckBox.TabIndex = 11;
            this.levelACheckBox.Text = "Level A";
            this.levelACheckBox.UseVisualStyleBackColor = true;
            this.levelACheckBox.Click += new System.EventHandler(this.LevelCheckBox_Click);
            // 
            // levelBCheckBox
            // 
            this.levelBCheckBox.AutoSize = true;
            this.levelBCheckBox.Enabled = false;
            this.levelBCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBCheckBox.Location = new System.Drawing.Point(333, 238);
            this.levelBCheckBox.Name = "levelBCheckBox";
            this.levelBCheckBox.Size = new System.Drawing.Size(80, 24);
            this.levelBCheckBox.TabIndex = 12;
            this.levelBCheckBox.Text = "Level B";
            this.levelBCheckBox.UseVisualStyleBackColor = true;
            this.levelBCheckBox.Click += new System.EventHandler(this.LevelCheckBox_Click);
            // 
            // levelCCheckBox
            // 
            this.levelCCheckBox.AutoSize = true;
            this.levelCCheckBox.Enabled = false;
            this.levelCCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelCCheckBox.Location = new System.Drawing.Point(333, 262);
            this.levelCCheckBox.Name = "levelCCheckBox";
            this.levelCCheckBox.Size = new System.Drawing.Size(80, 24);
            this.levelCCheckBox.TabIndex = 13;
            this.levelCCheckBox.Text = "Level C";
            this.levelCCheckBox.UseVisualStyleBackColor = true;
            this.levelCCheckBox.CheckedChanged += new System.EventHandler(this.LevelCCheckBox_CheckedChanged);
            this.levelCCheckBox.Click += new System.EventHandler(this.LevelCheckBox_Click);
            // 
            // CensorPartListBox
            // 
            this.CensorPartListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CensorPartListBox.FormattingEnabled = true;
            this.CensorPartListBox.ItemHeight = 20;
            this.CensorPartListBox.Location = new System.Drawing.Point(12, 83);
            this.CensorPartListBox.Name = "CensorPartListBox";
            this.CensorPartListBox.Size = new System.Drawing.Size(314, 344);
            this.CensorPartListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 444);
            this.Controls.Add(this.levelCCheckBox);
            this.Controls.Add(this.levelBCheckBox);
            this.Controls.Add(this.levelACheckBox);
            this.Controls.Add(this.exportCnsButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.removeCensorPartButton);
            this.Controls.Add(this.exportM3u8Button);
            this.Controls.Add(this.addCensorPartButton);
            this.Controls.Add(this.CensorPartListBox);
            this.Controls.Add(this.desTextBox);
            this.Controls.Add(this.srcTextBox);
            this.Controls.Add(this.srcButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button srcButton;
        private System.Windows.Forms.TextBox srcTextBox;
        private System.Windows.Forms.TextBox desTextBox;
        private System.Windows.Forms.Button addCensorPartButton;
        private System.Windows.Forms.Button exportM3u8Button;
        private System.Windows.Forms.Button removeCensorPartButton;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportCnsButton;
        private System.Windows.Forms.CheckBox levelACheckBox;
        private System.Windows.Forms.CheckBox levelBCheckBox;
        private System.Windows.Forms.CheckBox levelCCheckBox;
        private System.Windows.Forms.ListBox CensorPartListBox;
    }
}

