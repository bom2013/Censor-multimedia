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
            this.desButton = new System.Windows.Forms.Button();
            this.srcTextBox = new System.Windows.Forms.TextBox();
            this.desTextBox = new System.Windows.Forms.TextBox();
            this.CensorPartListBox = new System.Windows.Forms.ListBox();
            this.addCensorPartButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.removeCensorPartButton = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.importButton = new System.Windows.Forms.Button();
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
            this.srcButton.Location = new System.Drawing.Point(762, 10);
            this.srcButton.Name = "srcButton";
            this.srcButton.Size = new System.Drawing.Size(77, 28);
            this.srcButton.TabIndex = 0;
            this.srcButton.Text = "Browse";
            this.srcButton.UseVisualStyleBackColor = true;
            this.srcButton.Click += new System.EventHandler(this.SrcButton_Click);
            // 
            // desButton
            // 
            this.desButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desButton.Location = new System.Drawing.Point(762, 47);
            this.desButton.Name = "desButton";
            this.desButton.Size = new System.Drawing.Size(77, 28);
            this.desButton.TabIndex = 1;
            this.desButton.Text = "Browse";
            this.desButton.UseVisualStyleBackColor = true;
            this.desButton.Click += new System.EventHandler(this.DesButton_Click);
            // 
            // srcTextBox
            // 
            this.srcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcTextBox.Location = new System.Drawing.Point(12, 12);
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.Size = new System.Drawing.Size(744, 26);
            this.srcTextBox.TabIndex = 2;
            this.srcTextBox.Leave += new System.EventHandler(this.SrcTextBox_Leave);
            // 
            // desTextBox
            // 
            this.desTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desTextBox.Location = new System.Drawing.Point(12, 49);
            this.desTextBox.Name = "desTextBox";
            this.desTextBox.Size = new System.Drawing.Size(744, 26);
            this.desTextBox.TabIndex = 3;
            this.desTextBox.Leave += new System.EventHandler(this.DesTextBox_Leave);
            // 
            // CensorPartListBox
            // 
            this.CensorPartListBox.FormattingEnabled = true;
            this.CensorPartListBox.Location = new System.Drawing.Point(12, 83);
            this.CensorPartListBox.Name = "CensorPartListBox";
            this.CensorPartListBox.Size = new System.Drawing.Size(200, 355);
            this.CensorPartListBox.TabIndex = 4;
            // 
            // addCensorPartButton
            // 
            this.addCensorPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCensorPartButton.Location = new System.Drawing.Point(218, 93);
            this.addCensorPartButton.Name = "addCensorPartButton";
            this.addCensorPartButton.Size = new System.Drawing.Size(75, 37);
            this.addCensorPartButton.TabIndex = 5;
            this.addCensorPartButton.Text = "Add";
            this.addCensorPartButton.UseVisualStyleBackColor = true;
            this.addCensorPartButton.Click += new System.EventHandler(this.AddCensorPartButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(218, 395);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 37);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // removeCensorPartButton
            // 
            this.removeCensorPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCensorPartButton.Location = new System.Drawing.Point(218, 136);
            this.removeCensorPartButton.Name = "removeCensorPartButton";
            this.removeCensorPartButton.Size = new System.Drawing.Size(75, 37);
            this.removeCensorPartButton.TabIndex = 7;
            this.removeCensorPartButton.Text = "Remove";
            this.removeCensorPartButton.UseVisualStyleBackColor = true;
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(311, 83);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(562, 349);
            this.WindowsMediaPlayer.TabIndex = 8;
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(218, 179);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 37);
            this.importButton.TabIndex = 9;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 444);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.removeCensorPartButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.addCensorPartButton);
            this.Controls.Add(this.CensorPartListBox);
            this.Controls.Add(this.desTextBox);
            this.Controls.Add(this.srcTextBox);
            this.Controls.Add(this.desButton);
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
        private System.Windows.Forms.Button desButton;
        private System.Windows.Forms.TextBox srcTextBox;
        private System.Windows.Forms.TextBox desTextBox;
        private System.Windows.Forms.ListBox CensorPartListBox;
        private System.Windows.Forms.Button addCensorPartButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button removeCensorPartButton;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button importButton;
    }
}

