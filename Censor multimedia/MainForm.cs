using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Censor_multimedia
{
    public partial class MainForm : Form
    {
        private string srcFilePath = "", desFilePath = "", fileName = "";
        private int fileDuration;
        private bool fileChanged = false;
        public static List<MediaPart> censorPartList = new List<MediaPart>();
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

        private void WindowsMediaPlayer_CurrentPlaylistChange(object sender, AxWMPLib._WMPOCXEvents_CurrentPlaylistChangeEvent e)
        {
            if (fileChanged)
            {
                addCensorPartButton.Enabled = true;
                removeCensorPartButton.Enabled = true;
                importButton.Enabled = true;
                exportM3u8Button.Enabled = true;
                exportCnsButton.Enabled = true;
                fileDuration = (int)WindowsMediaPlayer.currentMedia.duration;
                fileName = WindowsMediaPlayer.currentMedia.name;
                desFilePath = getPathFromFullPath(srcFilePath) + fileName + "-Censored";
                desTextBox.Text = desFilePath;
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

        private void ExportButton_Click(object sender, EventArgs e)
        {
            groupUnification(censorPartList);
            List<MediaPart> viewablePartsList = createOppositeList(censorPartList, fileDuration);
            string m3u8Text = viewablePartsListToM3U8file(viewablePartsList, srcFilePath, fileName, fileDuration);
            File.WriteAllText(desFilePath + ".m3u8", m3u8Text);
        }

        private string getPathFromFullPath(string fullPath)
        {
            return fullPath.Substring(0, fullPath.LastIndexOf("\\")) + "\\";
        }

        private static List<MediaPart> groupUnification(List<MediaPart> censorPartsList)
        {
            censorPartList.Sort(delegate (MediaPart a, MediaPart b)
            {
                if (a.getStartTimeInSecond() == b.getStartTimeInSecond())
                    return 0;
                if (a.getStartTimeInSecond() < b.getStartTimeInSecond())
                    return -1;
                return 1;
            });
            for (int i = 0; i < censorPartList.Count; i++)
            {
                MediaPart partList = censorPartList[i];
                int startTime = partList.getStartTimeInSecond();
                int stopTime = partList.getStopTimeInSecond();
                for (int j = i + 1; j < censorPartList.Count; j++)
                {
                    MediaPart tCensorPart = censorPartList[j];
                    if (tCensorPart.getStartTimeInSecond() >= startTime && tCensorPart.getStartTimeInSecond() <= stopTime)
                    {
                        censorPartList.Insert(i, new MediaPart(startTime, Math.Max(stopTime, tCensorPart.getStopTimeInSecond())));
                        censorPartList.RemoveAt(i + 1);
                        censorPartList.RemoveAt(j);
                    }
                }
            }
            return censorPartList;
        }

        private void ExportCnsButton_Click(object sender, EventArgs e)
        {
            groupUnification(censorPartList);
            List<MediaPart> viewablePartsList = createOppositeList(censorPartList, fileDuration);
            string cnsText = viewablePartsListToCnsFile(viewablePartsList);
            File.WriteAllText(desFilePath + ".cns", cnsText);
        }

        public static List<MediaPart> createOppositeList(List<MediaPart> censorPartList, int mediaLength)
        {
            List<MediaPart> viewablePartsList = new List<MediaPart>();
            int curTime = 0;
            foreach (var censorPart in censorPartList)
            {
                if (curTime != censorPart.getStartTimeInSecond())
                    viewablePartsList.Add(new MediaPart(curTime, censorPart.getStartTimeInSecond()));
                curTime = censorPart.getStopTimeInSecond();
            }
            if (curTime != mediaLength)
                viewablePartsList.Add(new MediaPart(curTime, mediaLength));
            return viewablePartsList;
        }

        public static string viewablePartsListToM3U8file(List<MediaPart> viewablePartsList, string filePath, string fileName, int fileDuration)
        {
            string res = "#EXTM3U\n#EXTINF:";
            res += fileDuration.ToString() + ", " + fileName + "\n";
            foreach (var viewablePart in viewablePartsList)
            {
                res += "#EXTVLCOPT:start-time=" + viewablePart.getStartTimeInSecond().ToString() + "\n";
                res += "#EXTVLCOPT:stop-time=" + viewablePart.getStopTimeInSecond().ToString() + "\n";
                res += filePath + "\n";
            }
            return res;
        }

        public static string viewablePartsListToCnsFile(List<MediaPart> viewablePartsList)
        {
            string res = "";
            foreach (var viewablePart in viewablePartsList)
            {
                int[] startTimeInHms = MediaPart.secondToHMS(viewablePart.getStartTimeInSecond());
                int[] stopTimeInHms = MediaPart.secondToHMS(viewablePart.getStopTimeInSecond());
                res += startTimeInHms[0].ToString() + ':' + startTimeInHms[1].ToString() + ':' + startTimeInHms[2].ToString() + "\n";
                res += stopTimeInHms[0].ToString() + ':' + stopTimeInHms[1].ToString() + ':' + stopTimeInHms[2].ToString() + "\n";
            }
            return res;
        }
    }
}
