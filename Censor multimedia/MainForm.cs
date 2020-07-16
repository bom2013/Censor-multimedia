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
        public static List<CensorPart> censorPartList = new List<CensorPart>();
        private char level = 'A';
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
                levelBCheckBox.Enabled = true;
                levelCCheckBox.Enabled = true;
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
            {
                censorPartList.Remove((CensorPart)CensorPartListBox.Items[CensorPartListBox.SelectedIndex]);
                RefreshListBox();
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                groupUnification(censorPartList);
                List<CensorPart> filteredCensorPartList = filterCensorPartByLevel(censorPartList);
                List<MediaPart> viewablePartsList = createOppositeList(filteredCensorPartList, fileDuration);
                string m3u8Text = viewablePartsListToM3U8file(viewablePartsList, srcFilePath, fileName, fileDuration);
                File.WriteAllText(desFilePath + ".m3u8", m3u8Text);
                MessageBox.Show("The file has been successfully exported and save at: " + desFilePath + ".m3u8\nEnjoy!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error export to m3u8 file");
            }
        }

        private string getPathFromFullPath(string fullPath)
        {
            return fullPath.Substring(0, fullPath.LastIndexOf("\\")) + "\\";
        }

        private static List<CensorPart> groupUnification(List<CensorPart> censorPartsList)
        {
            censorPartList.Sort(delegate (CensorPart a, CensorPart b)
            {
                if (a.getStartTimeInSecond() == b.getStartTimeInSecond())
                    return 0;
                if (a.getStartTimeInSecond() < b.getStartTimeInSecond())
                    return -1;
                return 1;
            });
            for (int i = 0; i < censorPartList.Count; i++)
            {
                CensorPart censorPart = censorPartList[i];
                int startTime = censorPart.getStartTimeInSecond();
                int stopTime = censorPart.getStopTimeInSecond();
                for (int j = i + 1; j < censorPartList.Count; j++)
                {
                    CensorPart tCensorPart = censorPartList[j];
                    if (tCensorPart.getStartTimeInSecond() >= startTime && tCensorPart.getStartTimeInSecond() <= stopTime)
                    {
                        censorPartList.Insert(i, new CensorPart(startTime,
                            Math.Max(stopTime, tCensorPart.getStopTimeInSecond()),
                            CensorPart.getMaxLevel(censorPart.getLevel(), tCensorPart.getLevel()),
                            censorPart.getMessage() + ", " + tCensorPart.getMessage()));
                        censorPartList.RemoveAt(i + 1);
                        censorPartList.RemoveAt(j);
                    }
                }
            }
            return censorPartList;
        }

        private void ExportCnsButton_Click(object sender, EventArgs e)
        {
            try
            {
                groupUnification(censorPartList);
                string cnsText = censorPartsListToCnsFile(censorPartList);
                File.WriteAllText(desFilePath + ".cns", cnsText);
                MessageBox.Show("The file has been successfully exported and save at: " + desFilePath + ".cns");
            }
            catch (Exception)
            {
                MessageBox.Show("Error export to cns file");
            }
        }

        public static List<MediaPart> createOppositeList(List<CensorPart> censorPartList, int mediaLength)
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

        private void ImportButton_Click(object sender, EventArgs e)
        {
            string[] fileText;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileText = File.ReadAllText(openFileDialog.FileName).Split('\n');
                try
                {
                    for (int i = 0; i < fileText.Length; i += 4)
                    {
                        int[] startPointHMS = Array.ConvertAll(fileText[i].Split(':'), int.Parse);
                        int[] stopPointHMS = Array.ConvertAll(fileText[i + 1].Split(':'), int.Parse);
                        char level = fileText[i + 2][0];
                        string message = fileText[i + 3];
                        censorPartList.Add(new CensorPart(
                            MediaPart.HMStoSeconds(startPointHMS[0], startPointHMS[1], startPointHMS[2]),
                            MediaPart.HMStoSeconds(stopPointHMS[0], stopPointHMS[1], stopPointHMS[2]),
                            level,
                            message
                            ));
                    }
                    RefreshListBox();
                    MessageBox.Show("The cns file was successfully imported");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error importing from file");
                }
            }
        }

        private void LevelCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (levelCCheckBox.Checked)
                levelBCheckBox.Checked = true;
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

        private void LevelCheckBox_Click(object sender, EventArgs e)
        {
            if (levelCCheckBox.Checked)
                level = 'C';
            else if (levelBCheckBox.Checked)
                level = 'B';
            else
                level = 'A';
        }

        public static string censorPartsListToCnsFile(List<CensorPart> censorPartList)
        {
            string res = "";
            foreach (var censorPart in censorPartList)
            {
                int[] startTimeInHms = MediaPart.secondToHMS(censorPart.getStartTimeInSecond());
                int[] stopTimeInHms = MediaPart.secondToHMS(censorPart.getStopTimeInSecond());
                res += startTimeInHms[0].ToString() + ':' + startTimeInHms[1].ToString() + ':' + startTimeInHms[2].ToString() + "\n";
                res += stopTimeInHms[0].ToString() + ':' + stopTimeInHms[1].ToString() + ':' + stopTimeInHms[2].ToString() + "\n";
                res += censorPart.getLevel() + "\n";
                res += censorPart.getMessage() + "\n";
            }
            return res.Substring(0, res.Length - 1);
        }

        private List<CensorPart> filterCensorPartByLevel(List<CensorPart> censorPartList)
        {
            List<CensorPart> resList = new List<CensorPart>();
            foreach (var censorPart in censorPartList)
            {
                if (CensorPart.isLevelbiggerOrEqualThan(censorPart.getLevel(), level))
                    resList.Add(censorPart);
            }
            return resList;
        }
    }
}
