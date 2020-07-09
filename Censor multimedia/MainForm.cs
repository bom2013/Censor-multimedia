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
    public partial class MainForm : Form
    {
        private string srcFileName = "", desFileName = "";
        private int fileDuration;
        public static List<CensorPart> censorPartList = new List<CensorPart>();
        public MainForm()
        {
            InitializeComponent();
        }


        private void AddCensorPartButton_Click(object sender, EventArgs e)
        {
            if (srcFileName == "")
            {
                MessageBox.Show("Load file before add censor part");
            }
            else
            {
                AddCensorPartForm addCensorPartForm = new AddCensorPartForm((int)WindowsMediaPlayer.currentMedia.duration);
                addCensorPartForm.Show();
                addCensorPartForm.FormClosing += (s, args) => this.RefreshListBox();
            }
        }

        private void DesButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                desFileName = openFileDialog.FileName;
            }
            desTextBox.Text = srcFileName;
        }

        private void SrcTextBox_Leave(object sender, EventArgs e)
        {
            srcFileName = srcTextBox.Text;
        }

        private void DesTextBox_Leave(object sender, EventArgs e)
        {
            desFileName = desTextBox.Text;
        }

        private void SrcButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                WindowsMediaPlayer.URL = openFileDialog.FileName;
                srcFileName = openFileDialog.FileName;
                srcTextBox.Text = srcFileName;
                System.Threading.Thread.Sleep(1000);
                fileDuration = (int)WindowsMediaPlayer.currentMedia.duration;
            }
        }
        private void RefreshListBox()
        {
            CensorPartListBox.Items.Clear();
            foreach (var item in censorPartList)
            {
                CensorPartListBox.Items.Add(item);
            }
        }
    }
}
