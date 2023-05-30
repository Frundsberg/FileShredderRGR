using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SimpleFileShredder
{
    public partial class frmShredder : Form
    {
        Random random;

        public frmShredder()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOverwite.SelectedIndex = 1;
            cmbOverwiteFolder.SelectedIndex = 1;
        }

        private void btnOverwrite_Click(object sender, EventArgs e)
        {
            if (overwriteFile(txtPath.Text, cmbOverwite.SelectedIndex))
                MessageBox.Show(txtPath.Text + " файл переписано успішно.");
        }

        private void btnShredFile_Click(object sender, EventArgs e)
        {
            if (overwriteFile(txtPath.Text, cmbOverwite.SelectedIndex))
            {
                File.Delete(txtPath.Text);
                MessageBox.Show(txtPath.Text + " утилізовано успішно.");
            }
        }

        bool overwriteFile(string filePath, int overwriteType)
        {
            if (File.Exists(filePath))
            {
                Cursor.Current = Cursors.WaitCursor;
                this.Text = "Перезапис... " + filePath;
                FileInfo fileInfo = new FileInfo(filePath);
                byte[] byteArr = new byte[fileInfo.Length];
                if (overwriteType == 0)
                {
                    // Виконувати операцію для типу 0
                }
                else
                {
                    random.NextBytes(byteArr); // Заповнюємо масив псевдовипадково згенерованими байтами
                }
                File.WriteAllBytes(filePath, byteArr);
                Cursor.Current = Cursors.Default;
                return true;
            }
            return false;
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (ofdFolder.ShowDialog() == DialogResult.OK)
            {
                txtPathFolder.Text = ofdFolder.SelectedPath;
                btnOverwriteFolder.Enabled = true;
                btnShredFolder.Enabled = true;
            }
        }

        private void btnOverwriteFolder_Click(object sender, EventArgs e)
        {
            overwriteFolder(false);
        }

        private void btnShredFolder_Click(object sender, EventArgs e)
        {
            overwriteFolder(true);
        }

        void overwriteFolder(bool delete)
        {
            if (Directory.Exists(txtPathFolder.Text))
            {
                string[] filePaths = Directory.GetFiles(txtPathFolder.Text);
                foreach (string path in filePaths)
                {
                    overwriteFile(path, cmbOverwiteFolder.SelectedIndex);
                    if (delete)
                        File.Delete(path);
                }
                if (delete)
                    Directory.Delete(txtPathFolder.Text);

                string msg = string.Empty;
                for (int i = 0; i < filePaths.Length; i++)
                {
                    if (i != filePaths.Length - 1)
                        msg += filePaths[i] + ",\n";
                    else
                    {
                        if (delete)
                        {
                            msg += string.Format("{0}\nzn{1}\nутилізовано успішно", filePaths[i], txtPathFolder.Text);
                        }
                        else
                            msg += filePaths[i] + "\nпереписано успішно";
                    }
                }
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show(
                    "Вибраної папки не існує.",
                    "Folder not found error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdBrowse.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofdBrowse.FileName;
                btnOverwrite.Enabled = true;
                btnShredFile.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обробка подій при зміні вибору в ComboBox
        }
    }
}