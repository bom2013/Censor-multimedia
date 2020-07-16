namespace Censor_multimedia
{
    partial class AddCensorPartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCensorPartForm));
            this.startHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startSecondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startMinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartPointLabel = new System.Windows.Forms.Label();
            this.StopPointLabel = new System.Windows.Forms.Label();
            this.stopMinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stopSecondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stopHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.acceptButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.levelARadioButton = new System.Windows.Forms.RadioButton();
            this.levelCRadioButton = new System.Windows.Forms.RadioButton();
            this.levelBRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.startHourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSecondNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopMinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopSecondNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopHourNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startHourNumericUpDown
            // 
            resources.ApplyResources(this.startHourNumericUpDown, "startHourNumericUpDown");
            this.startHourNumericUpDown.Name = "startHourNumericUpDown";
            // 
            // startSecondNumericUpDown
            // 
            resources.ApplyResources(this.startSecondNumericUpDown, "startSecondNumericUpDown");
            this.startSecondNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startSecondNumericUpDown.Name = "startSecondNumericUpDown";
            // 
            // startMinuteNumericUpDown
            // 
            resources.ApplyResources(this.startMinuteNumericUpDown, "startMinuteNumericUpDown");
            this.startMinuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMinuteNumericUpDown.Name = "startMinuteNumericUpDown";
            // 
            // StartPointLabel
            // 
            resources.ApplyResources(this.StartPointLabel, "StartPointLabel");
            this.StartPointLabel.Name = "StartPointLabel";
            // 
            // StopPointLabel
            // 
            resources.ApplyResources(this.StopPointLabel, "StopPointLabel");
            this.StopPointLabel.Name = "StopPointLabel";
            // 
            // stopMinuteNumericUpDown
            // 
            resources.ApplyResources(this.stopMinuteNumericUpDown, "stopMinuteNumericUpDown");
            this.stopMinuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.stopMinuteNumericUpDown.Name = "stopMinuteNumericUpDown";
            // 
            // stopSecondNumericUpDown
            // 
            resources.ApplyResources(this.stopSecondNumericUpDown, "stopSecondNumericUpDown");
            this.stopSecondNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.stopSecondNumericUpDown.Name = "stopSecondNumericUpDown";
            // 
            // stopHourNumericUpDown
            // 
            resources.ApplyResources(this.stopHourNumericUpDown, "stopHourNumericUpDown");
            this.stopHourNumericUpDown.Name = "stopHourNumericUpDown";
            // 
            // acceptButton
            // 
            resources.ApplyResources(this.acceptButton, "acceptButton");
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // messageTextBox
            // 
            resources.ApplyResources(this.messageTextBox, "messageTextBox");
            this.messageTextBox.Name = "messageTextBox";
            // 
            // levelARadioButton
            // 
            resources.ApplyResources(this.levelARadioButton, "levelARadioButton");
            this.levelARadioButton.Checked = true;
            this.levelARadioButton.Name = "levelARadioButton";
            this.levelARadioButton.TabStop = true;
            this.levelARadioButton.UseVisualStyleBackColor = true;
            // 
            // levelCRadioButton
            // 
            resources.ApplyResources(this.levelCRadioButton, "levelCRadioButton");
            this.levelCRadioButton.Name = "levelCRadioButton";
            this.levelCRadioButton.TabStop = true;
            this.levelCRadioButton.UseVisualStyleBackColor = true;
            // 
            // levelBRadioButton
            // 
            resources.ApplyResources(this.levelBRadioButton, "levelBRadioButton");
            this.levelBRadioButton.Name = "levelBRadioButton";
            this.levelBRadioButton.TabStop = true;
            this.levelBRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddCensorPartForm
            // 
            this.AcceptButton = this.acceptButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.levelBRadioButton);
            this.Controls.Add(this.levelCRadioButton);
            this.Controls.Add(this.levelARadioButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.stopMinuteNumericUpDown);
            this.Controls.Add(this.stopSecondNumericUpDown);
            this.Controls.Add(this.stopHourNumericUpDown);
            this.Controls.Add(this.StopPointLabel);
            this.Controls.Add(this.StartPointLabel);
            this.Controls.Add(this.startMinuteNumericUpDown);
            this.Controls.Add(this.startSecondNumericUpDown);
            this.Controls.Add(this.startHourNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCensorPartForm";
            ((System.ComponentModel.ISupportInitialize)(this.startHourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSecondNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopMinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopSecondNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopHourNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown startHourNumericUpDown;
        private System.Windows.Forms.NumericUpDown startSecondNumericUpDown;
        private System.Windows.Forms.NumericUpDown startMinuteNumericUpDown;
        private System.Windows.Forms.Label StartPointLabel;
        private System.Windows.Forms.Label StopPointLabel;
        private System.Windows.Forms.NumericUpDown stopMinuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown stopSecondNumericUpDown;
        private System.Windows.Forms.NumericUpDown stopHourNumericUpDown;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.RadioButton levelARadioButton;
        private System.Windows.Forms.RadioButton levelCRadioButton;
        private System.Windows.Forms.RadioButton levelBRadioButton;
    }
}