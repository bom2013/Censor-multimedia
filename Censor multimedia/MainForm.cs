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
        private string srcFileName, desFileName;
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddCensorPartButton_Click(object sender, EventArgs e)
        {

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
                srcFileName = openFileDialog.FileName;
            }
            srcTextBox.Text = srcFileName;
        }
    }
}
