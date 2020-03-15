using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private bool IsToCipher = true;
        public CipherForm()
        {
            InitializeComponent();
            this.CaesarProcessModeComboBox.SelectedIndex = 0;
        }

        private void CipherForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.splitContainer1.SplitterDistance = ClientSize.Height / 2;
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            this.CaesarBeforeProccesTextBox.Text = Clipboard.GetText();
        }

        private void CaesarCopyButton_Click(object sender, EventArgs e)
        {
            if (CaesarAfterProcessTextBox.Text != null)
                Clipboard.SetText(CaesarAfterProcessTextBox.Text);
        }

        private void CaesarProcessModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cipher
            if (this.CaesarProcessModeComboBox.SelectedIndex == 0)
            {
                this.CaesarBeforeProcessButton.Text = "Зашифровать";
                this.IsToCipher = true;
            }
            else // Decipher
            {
                this.CaesarBeforeProcessButton.Text = "Расшифровать";
                this.IsToCipher = false;
            }
        }

        private void CaesarBeforeProcessButton_Click(object sender, EventArgs e)
        {
            if (CaesarBeforeProccesTextBox.Text != null)
            {
                if (this.IsToCipher)
                    this.CaesarAfterProcessTextBox.Text = CiphersDeciphers.CaesarCipherDecipher(
                            Convert.ToInt32(CaesarStepUpDown.Value), 
                            CaesarBeforeProccesTextBox.Text
                        );
                else
                    this.CaesarAfterProcessTextBox.Text = CiphersDeciphers.CaesarCipherDecipher(
                            -Convert.ToInt32(CaesarStepUpDown.Value), 
                            CaesarBeforeProccesTextBox.Text
                        );
            }
        }
    }
}
