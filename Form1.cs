using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
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

            this.DiffieHellmanKeySplitContainer.SplitterDistance = this.DiffieHellmanCaptionLabel.Width + 50;
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
                            Convert.ToInt32(this.CaesarStepUpDown.Value),
                            this.CaesarBeforeProcessTextBox.Text
                        )
                    : this.CaesarAfterProcessTextBox.Text = CiphersDeciphers.CaesarEncodeDecode(
                            -Convert.ToInt32(this.CaesarStepUpDown.Value),
                            this.CaesarBeforeProcessTextBox.Text
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

        private void DiffieHellmanTab_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.DiffieHellmanKeySplitContainer.SplitterDistance = this.DiffieHellmanCaptionLabel.Width + 50;
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

                
                this.VigenereAfterProcessTextBox.Text = CiphersDeciphers.VigenereEncodeDecode(
                    this.VigenereBeforeProcessTextBox.Text,
                    temp,
                    this.VigenereIsToCipher
                );
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

        private void DiffieHellmanButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(this.DiffieHellmanInsertUpDown.Value);

            if (number > 2 && number <= 2000)
            {
                KeyValuePair<int, int>? buff = CiphersDeciphers.SetDictionaryOfPublicKeys(number);

                if (buff != null)
                {
                    this.DiffieHellmanPrimeTextBox.Text = buff.Value.Key.ToString();
                    this.DiffieHellmanGeneratorTextBox.Text = buff.Value.Value.ToString();
                }
            }
            else
            {
                MessageBox.Show(
                    "Введите корректное число от 3 до 1000",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            bool isP = int.TryParse(this.DiffieHellmanPrimeTextBox.Text, out int prime);
            bool isG = int.TryParse(this.DiffieHellmanGeneratorTextBox.Text, out int gen);
            //if input is number

            if (isP && isG && CiphersDeciphers.IsPrime(prime) && CiphersDeciphers.IsPrimitiveRoot(gen, prime))
                this.DiffieHellmanResultLabel.Text = $"{prime},{gen}";
            else
                MessageBox.Show(
                    "Ключ введён неверно",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }

        private void DiffieHellmanCollapseKeyButton_Click(object sender, EventArgs e)
        {
            this.DiffieHellmanKeySplitContainer.Panel1Collapsed = !this.DiffieHellmanKeySplitContainer.Panel1Collapsed;

            this.DiffieHellmanCollapseKeyButton.Text = (this.DiffieHellmanKeySplitContainer.Panel1Collapsed)
                ? "→→→"  // To open
                : "←←←"; // To close
        }

        private void DiffieHellmanCalcOwnKeyButton_Click(object sender, EventArgs e)
        {
            if (this.DiffieHellmanResultLabel.Text.Length > 0)
            {
                string[] result = this.DiffieHellmanResultLabel.Text.Split(',');

                int prime = Convert.ToInt32(result[0]);
                int gen = Convert.ToInt32(result[1]);
                var key = Convert.ToInt16(this.DiffieHellmanOwnKeyUpDown.Value);
                System.Console.WriteLine($"{gen}, {prime}, {key}");

                this.DiffieHellmanOwnKeyResultLabel.Text = CiphersDeciphers.DiffieHellmanCalcKey(key, gen, prime).ToString();
            }
        }

        private void DiffieHellmanCalcPartnerKeyButton_Click(object sender, EventArgs e)
        {
            if (this.DiffieHellmanResultLabel.Text.Length > 0)
            {
                string[] result = this.DiffieHellmanResultLabel.Text.Split(',');

                var prime = BigInteger.Parse(result[0]);
                var gen = BigInteger.Parse(result[1]);
                var key = Convert.ToInt16(this.DiffieHellmanPartnerKeyUpDown.Value);
                System.Console.WriteLine($"{gen}, {prime}, {key}");

                this.DiffieHellmanPartnerKeyResultUpDown.Value = Convert.ToDecimal(CiphersDeciphers.DiffieHellmanCalcKey(key, gen, prime).ToString());
            }
        }
    }
}
