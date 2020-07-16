using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Censor_multimedia
{
    public partial class AddCensorPartForm : Form
    {
        private int duration = 0;

        public AddCensorPartForm()
        {
            InitializeComponent();
        }

        public AddCensorPartForm(int duration)
        {
            this.duration = duration;
            InitializeComponent();
            int[] hmsDuration = MediaPart.secondToHMS(duration);
            startHourNumericUpDown.Maximum = stopHourNumericUpDown.Maximum = hmsDuration[0];
        }

        private bool checkIfBigger(int startPointInSeconds, int stoptPointInSeconds)
        {
            if (stoptPointInSeconds > startPointInSeconds)
                return true;
            return false;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int startPointInSeconds = MediaPart.HMStoSeconds((int)startHourNumericUpDown.Value, (int)startMinuteNumericUpDown.Value, (int)startSecondNumericUpDown.Value);
            int stopPointInSeconds = MediaPart.HMStoSeconds((int)stopHourNumericUpDown.Value, (int)stopMinuteNumericUpDown.Value, (int)stopSecondNumericUpDown.Value);
            if (checkIfBigger(startPointInSeconds, stopPointInSeconds))
            {
                if (startPointInSeconds <= duration && stopPointInSeconds <= duration)
                {
                    MainForm.censorPartList.Add(
                        new CensorPart(
                            startPointInSeconds,
                            stopPointInSeconds,
                            getLevel(),
                            messageTextBox.Text
                            ));
                    this.Close();
                }
                else
                    MessageBox.Show("Cant be bigger than media duration");
            }
            else
                MessageBox.Show("Stop point must be bigger then start point");
        }

        private char getLevel()
        {
            if (levelARadioButton.Checked)
                return 'A';
            if (levelBRadioButton.Checked)
                return 'B';
            return 'C';
        }
    }
}
