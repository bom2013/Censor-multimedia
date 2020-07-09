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
            int[] hmsDuration = CensorPart.secondToHMS(duration);
            startHourNumericUpDown.Maximum = stopHourNumericUpDown.Maximum = hmsDuration[0];
            startMinuteNumericUpDown.Maximum = stopMinuteNumericUpDown.Maximum = hmsDuration[1];
            startSecondNumericUpDown.Maximum = stopSecondNumericUpDown.Maximum = hmsDuration[2];
        }
        private bool checkIfBigger(int startPointInSeconds,int stoptPointInSeconds)
        {
            if (stoptPointInSeconds > startPointInSeconds)
                return true;
            return false;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int startPointInSeconds = CensorPart.HMStoSeconds((int)startHourNumericUpDown.Value, (int)startMinuteNumericUpDown.Value, (int)startSecondNumericUpDown.Value);
            int stopPointInSeconds = CensorPart.HMStoSeconds((int)stopHourNumericUpDown.Value, (int)stopMinuteNumericUpDown.Value, (int)stopSecondNumericUpDown.Value);
            if (checkIfBigger(startPointInSeconds, stopPointInSeconds))
            {
                MainForm.censorPartList.Add(new CensorPart(startPointInSeconds, stopPointInSeconds));
                this.Close();
            }
            else
                MessageBox.Show("Stop point must be bigger then start point");
        }
    }
}
