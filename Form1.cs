using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherDecipher
{
    public partial class CipherForm : Form
    {
        public const string RUS_ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public const string ENG_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private bool CaesarIsToCipher = true;
        private bool VigenereIsToCipher = true;

        public CipherForm()
        {
            InitializeComponent();
            this.CaesarProcessModeComboBox.SelectedIndex = 0;
            this.VigenereProcessModeComboBox.SelectedIndex = 0;
        }

        private void CipherForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.CaesarSplitContainer.SplitterDistance = ClientSize.Height / 2;
                this.VigenereSplitContainer.SplitterDistance = ClientSize.Height / 2;
            }
        }

        private void CaesarCopyButton_Click(object sender, EventArgs e)
        {
            if (this.CaesarAfterProcessTextBox.Text != null)
                Clipboard.SetText(this.CaesarAfterProcessTextBox.Text);
        }

        private void CaesarProcessModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cipher
            if (this.CaesarProcessModeComboBox.SelectedIndex == 0)
            {
                this.CaesarBeforeProcessButton.Text = "Зашифровать";
                this.CaesarIsToCipher = true;
            }
            else // Decipher
            {
                this.CaesarBeforeProcessButton.Text = "Расшифровать";
                this.CaesarIsToCipher = false;
            }
        }

        private void CaesarBeforeProcessButton_Click(object sender, EventArgs e)
        {
            if (CaesarBeforeProcessTextBox.Text != null)
            {
                this.CaesarAfterProcessTextBox.Text = (this.CaesarIsToCipher)
                    ? this.CaesarAfterProcessTextBox.Text = CiphersDeciphers.CaesarCipherDecipher(
                            Convert.ToInt32(CaesarStepUpDown.Value),
                            CaesarBeforeProcessTextBox.Text
                        )
                    : this.CaesarAfterProcessTextBox.Text = CiphersDeciphers.CaesarCipherDecipher(
                            -Convert.ToInt32(CaesarStepUpDown.Value),
                            CaesarBeforeProcessTextBox.Text
                        );
            }
        }

        private void CaesarAfterProcessTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CaesarAfterProcessTextBox.Text.Length > 0)
            {
                this.CaesarCopyButton.Enabled = true;
                this.CaesarSaveToFileButton.Enabled = true;
            }
            else
            {
                this.CaesarCopyButton.Enabled = false;
                this.CaesarSaveToFileButton.Enabled = false;
            }
        }

        private void CaesarSaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "untitled";
            sfd.Filter = "Text (*.txt)|*.txt";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, this.CaesarAfterProcessTextBox.Text);
            }
            sfd.Dispose();
        }

        private void CaesarTab_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.CaesarSplitContainer.SplitterDistance = ClientSize.Height / 2;
            }
        }

        private void VigenereTab_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.VigenereSplitContainer.SplitterDistance = ClientSize.Height / 2;
            }
        }

        private void VigenerePasteButton_Click(object sender, EventArgs e)
        {
            this.VigenereBeforeProcessTextBox.Text = Clipboard.GetText();
        }

        private void CaesarPasteButton_Click(object sender, EventArgs e)
        {
            this.CaesarBeforeProcessTextBox.Text = Clipboard.GetText();
        }

        private void VigenereProcessModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cipher
            if (this.VigenereProcessModeComboBox.SelectedIndex == 0)
            {
                this.VigenereBeforeProcessButton.Text = "Зашифровать";
                this.VigenereIsToCipher = true;
            }
            else // Decipher
            {
                this.VigenereBeforeProcessButton.Text = "Расшифровать";
                this.VigenereIsToCipher = false;
            }
        }

        private void VigenereCopyButton_Click(object sender, EventArgs e)
        {
            if (this.VigenereAfterProcessTextBox.Text != null)
                Clipboard.SetText(this.VigenereAfterProcessTextBox.Text);
        }

        private void VigenereSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "untitled";
            sfd.Filter = "Text (*.txt)|*.txt";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, this.VigenereAfterProcessTextBox.Text);
            }
            sfd.Dispose();
        }

        private void VigenereBeforeProcessButton_Click(object sender, EventArgs e)
        {
            //TODO VigenereCipher
        }
    }
}
