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
        private bool DiffieHellmanIsToCipher = true;

        public static Dictionary<int, int> DiffieOpenKeysDictionary = new Dictionary<int, int>();

        public CipherForm()
        {
            InitializeComponent();
            this.CaesarProcessModeComboBox.SelectedIndex = 0;
            this.VigenereProcessModeComboBox.SelectedIndex = 0;
            this.DiffieHellmanProcessModeComboBox.SelectedIndex = 0;
        }

        //to prevent form from lagging on resize
        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
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
                this.CaesarProcessButton.Text = "Зашифровать";
                this.CaesarIsToCipher = true;
            }
            else // Decipher
            {
                this.CaesarProcessButton.Text = "Расшифровать";
                this.CaesarIsToCipher = false;
            }
        }

        private void CaesarProcessButton_Click(object sender, EventArgs e)
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
                this.CaesarSplitContainer.SplitterDistance = this.CaesarTab.Size.Height / 2;
        }

        private void VigenereTab_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.VigenereSplitContainer.SplitterDistance = this.CaesarTab.Size.Height / 2;
        }

        private void DiffieHellmanTab_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.DiffieHellmanKeySplitContainer.SplitterDistance = this.DiffieHellmanCaptionLabel.Width + 25;
                this.DiffieHellmanEncodeSplitContainer.SplitterDistance = this.DiffieHellmanTab.Size.Height / 2;
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
                this.VigenereProcessButton.Text = "Зашифровать";
                this.VigenereIsToCipher = true;
            }
            else // Decipher
            {
                this.VigenereProcessButton.Text = "Расшифровать";
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

        private void VigenereProcessButton_Click(object sender, EventArgs e)
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
                MessageBox.Show(
                    "Введите ключ", 
                    "Сообщение", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
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
                    this.DiffieHellmanPrimeUpDown.Value = buff.Value.Key;
                    this.DiffieHellmanGeneratorUpDown.Value = buff.Value.Value;
                }
            }
            else
                MessageBox.Show(
                    "Введите корректное число от 3 до 1000",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }

        private void DiffieHellmanSendOpenKeyButton_Click(object sender, EventArgs e)
        {
            var prime = Convert.ToInt32(this.DiffieHellmanPrimeUpDown.Value);
            var gen = Convert.ToInt32(this.DiffieHellmanGeneratorUpDown.Value);
            //if input is number

            if (CiphersDeciphers.IsPrime(prime) && CiphersDeciphers.IsPrimitiveRoot(gen, prime))
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

        private void DiffieHellmanGetOwnPrivateKeyButton_Click(object sender, EventArgs e)
        {
            if (this.DiffieHellmanOwnKeyUpDown.Value > 0 && this.DiffieHellmanPartnerKeyUpDown.Value > 0)
            {
                string[] result = this.DiffieHellmanResultLabel.Text.Split(',');

                var prime = BigInteger.Parse(result[0]);
                var gen = BigInteger.Parse(this.DiffieHellmanPartnerKeyResultUpDown.Value.ToString());
                var key = Convert.ToInt16(this.DiffieHellmanOwnKeyUpDown.Value);

                this.DiffieHellmanGetOwnPrivateKeyLabel.Text = CiphersDeciphers.DiffieHellmanCalcKey(key, gen, prime).ToString();
            }
        }

        private void DiffieHellmanGetPartnerPrivateKeyButton_Click(object sender, EventArgs e)
        {
            if (this.DiffieHellmanPartnerKeyUpDown.Value > 0 && this.DiffieHellmanOwnKeyResultLabel.Text != String.Empty)
            {
                string[] result = this.DiffieHellmanResultLabel.Text.Split(',');

                var prime = BigInteger.Parse(result[0]);
                var gen = BigInteger.Parse(this.DiffieHellmanOwnKeyResultLabel.Text);
                var key = Convert.ToInt16(this.DiffieHellmanPartnerKeyUpDown.Value);

                this.DiffieHellmanGetPartnerPrivateKeyLabel.Text = CiphersDeciphers.DiffieHellmanCalcKey(key, gen, prime).ToString();
            }
        }

        private void DiffieHellmanAfterProcessTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.DiffieHellmanAfterProcessTextBox.Text.Length > 0)
            {
                this.DiffieHellmanCopyButton.Enabled = true;
                this.DiffieHellmanSaveToFileButton.Enabled = true;
            }
            else
            {
                this.DiffieHellmanCopyButton.Enabled = false;
                this.DiffieHellmanSaveToFileButton.Enabled = false;
            }
        }

        private void DiffieHellmanProcessModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DiffieHellmanProcessModeComboBox.SelectedIndex == 0)
            {
                this.DiffieHellmanProcessButton.Text = "Зашифровать";
                this.DiffieHellmanIsToCipher = true;
            }
            else // Decipher
            {
                this.DiffieHellmanProcessButton.Text = "Расшифровать";
                this.DiffieHellmanIsToCipher = false;
            }
        }

        private void DiffieHellmanPasteFromFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
                this.DiffieHellmanBeforeProcessTextBox.Text = File.ReadAllText(ofd.FileName, Encoding.GetEncoding(1251));
        }

        private void DiffieHellmanPasteButton_Click(object sender, EventArgs e)
        {
            if (this.DiffieHellmanBeforeProcessTextBox.Text.Length > 0 && Clipboard.ContainsText())
            {
                var result = MessageBox.Show(
                    "Вставленный текст заменит текущий. Заменить?", 
                    "Предупреждение", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                    this.DiffieHellmanBeforeProcessTextBox.Text = Clipboard.GetText();
            }
        }

        private void DiffieHellmanCopyButton_Click(object sender, EventArgs e)
        {
            if (this.DiffieHellmanAfterProcessTextBox.Text.Length > 0)
                Clipboard.SetText(this.DiffieHellmanAfterProcessTextBox.Text);
        }

        private void DiffieHellmanSaveToFileButton_Click(object sender, EventArgs e)
        {
            if (this.DiffieHellmanAfterProcessTextBox.Text.Length > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files (*.txt)|*.txt";

                if(sfd.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(sfd.FileName, this.DiffieHellmanAfterProcessTextBox.Text);
            }
              
        }

        private void DiffieHellmanProcessButton_Click(object sender, EventArgs e)
        {
            if (this.DiffieHellmanGetOwnPrivateKeyLabel.Text.Length > 0)
            {
                if (this.DiffieHellmanKeyTextBox.Text.Length > 0)
                {
                    string temp = Regex.Replace(this.DiffieHellmanKeyTextBox.Text, " ", string.Empty);

                    temp = CiphersDeciphers.TransformKeyString(temp, Convert.ToInt32(this.DiffieHellmanGetOwnPrivateKeyLabel.Text));

                    this.DiffieHellmanAfterProcessTextBox.Text = CiphersDeciphers.VigenereEncodeDecode(
                        this.DiffieHellmanBeforeProcessTextBox.Text,
                        temp,
                        this.DiffieHellmanIsToCipher
                    );
                }
                else
                    MessageBox.Show(
                        "Введите ключ",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }
    }
}
