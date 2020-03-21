using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherDecipher
{
    public partial class CipherForm : Form
    {

        private bool CaesarIsToCipher = true;
        private bool VigenereIsToCipher = true;

        public static Dictionary<int, int> DiffieOpenKeysDictionary = new Dictionary<int, int>();

        public CipherForm()
        {
            InitializeComponent();
            this.CaesarProcessModeComboBox.SelectedIndex = 0;
            this.VigenereProcessModeComboBox.SelectedIndex = 0;
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
            if (this.CaesarBeforeProcessTextBox.Text != null)
            {
                this.CaesarAfterProcessTextBox.Text = (this.CaesarIsToCipher)
                    ? this.CaesarAfterProcessTextBox.Text = CiphersDeciphers.CaesarEncodeDecode(
                            Convert.ToInt32(CaesarStepUpDown.Value),
                            CaesarBeforeProcessTextBox.Text
                        )
                    : this.CaesarAfterProcessTextBox.Text = CiphersDeciphers.CaesarEncodeDecode(
                            -Convert.ToInt32(CaesarStepUpDown.Value),
                            CaesarBeforeProcessTextBox.Text
                        );
            }
        }

        private void CaesarAfterProcessTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.CaesarAfterProcessTextBox.Text.Length > 0)
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
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = "untitled",
                Filter = "Text (*.txt)|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, this.CaesarAfterProcessTextBox.Text);

            sfd.Dispose();
        }

        private void CaesarTab_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.CaesarSplitContainer.SplitterDistance = ClientSize.Height / 2;
        }

        private void VigenereTab_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.VigenereSplitContainer.SplitterDistance = ClientSize.Height / 2;
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
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = "untitled",
                Filter = "Text (*.txt)|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, this.VigenereAfterProcessTextBox.Text);

            sfd.Dispose();
        }

        private void VigenereBeforeProcessButton_Click(object sender, EventArgs e)
        {
            if (this.VigenereKeyTextBox.Text.Length > 0)
            {
                string temp = Regex.Replace(this.VigenereKeyTextBox.Text, " ", string.Empty);

                if (this.VigenereIsToCipher)
                    this.VigenereAfterProcessTextBox.Text = CiphersDeciphers.VigenereEncode(VigenereBeforeProcessTextBox.Text, temp);
                else
                    this.VigenereAfterProcessTextBox.Text = CiphersDeciphers.VigenereDecode(VigenereBeforeProcessTextBox.Text, temp);
            }
            else
            {
                MessageBox.Show(
                    "Введите ключ", 
                    "Сообщение", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
            
        }

        private void VigenereAfterProcessTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.VigenereAfterProcessTextBox.Text.Length > 0)
            {
                this.VigenereCopyButton.Enabled = true;
                this.VigenereSaveToFileButton.Enabled = true;
            }
            else
            {
                this.VigenereCopyButton.Enabled = false;
                this.VigenereSaveToFileButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = int.TryParse(textBox1.Text, out int number);

            if (result && number > 1 && number < 1000)
                CiphersDeciphers.SetDictionaryOfPublicKeys(number);
            else
            {
                MessageBox.Show(
                    "Введите корректное число от 1 до 1000",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
