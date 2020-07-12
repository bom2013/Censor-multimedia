using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Censor_multimedia
{
    public partial class MainForm : Form
    {
        private string srcFilePath = "", desFilePath = "";
        private int fileDuration;
        private bool fileChanged = false;
        public static List<CensorPart> censorPartList = new List<CensorPart>();
        public MainForm()
        {
            InitializeComponent();
        }


        private void AddCensorPartButton_Click(object sender, EventArgs e)
        {
            if (srcFilePath == "")
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

        private void SrcTextBox_Leave(object sender, EventArgs e)
        {
            srcFilePath = srcTextBox.Text;
        }


        private void SrcButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                WindowsMediaPlayer.URL = openFileDialog.FileName;
                srcFilePath = openFileDialog.FileName;
                srcTextBox.Text = srcFilePath;

                desFilePath = getPathFromFullPath(srcFilePath);
                desTextBox.Text = desFilePath;
            }
        }
        static public void CurrMediaAvailable(string name)
        {
            int x = 0;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void RefreshListBox()
        {
            CensorPartListBox.Items.Clear();
            foreach (var item in censorPartList)
            {
                CensorPartListBox.Items.Add(item);
            }
        }

        private void WindowsMediaPlayer_CurrentPlaylistChange(object sender, AxWMPLib._WMPOCXEvents_CurrentPlaylistChangeEvent e)
        {
            if (fileChanged)
            {
                addCensorPartButton.Enabled = true;
                removeCensorPartButton.Enabled = true;
                importButton.Enabled = true;
                exportButton.Enabled = true;
                fileDuration = (int)WindowsMediaPlayer.currentMedia.duration;
                MessageBox.Show("File load, now you can add censor parts");
            }
            fileChanged = true;
        }

        private void RemoveCensorPartButton_Click(object sender, EventArgs e)
        {
            if (CensorPartListBox.SelectedIndex == -1)
                SystemSounds.Hand.Play();
            else
                CensorPartListBox.Items.RemoveAt(CensorPartListBox.SelectedIndex);
        }

        private string getPathFromFullPath(string fullPath)
        {
            return fullPath.Substring(0, fullPath.LastIndexOf("\\")) + "\\";
        }
    }
}
