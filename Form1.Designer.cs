namespace CipherDecipher
{
    partial class CipherForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CipherTabControl = new System.Windows.Forms.TabControl();
            this.CaesarTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LeftCaesarTextBox = new System.Windows.Forms.TextBox();
            this.RightCaesarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VigenereTab = new System.Windows.Forms.TabPage();
            this.DiffieHellmanTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CipherTabControl.SuspendLayout();
            this.CaesarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CipherTabControl
            // 
            this.CipherTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CipherTabControl.Controls.Add(this.CaesarTab);
            this.CipherTabControl.Controls.Add(this.VigenereTab);
            this.CipherTabControl.Controls.Add(this.DiffieHellmanTab);
            this.CipherTabControl.Location = new System.Drawing.Point(-1, -1);
            this.CipherTabControl.Name = "CipherTabControl";
            this.CipherTabControl.SelectedIndex = 0;
            this.CipherTabControl.Size = new System.Drawing.Size(785, 566);
            this.CipherTabControl.TabIndex = 0;
            // 
            // CaesarTab
            // 
            this.CaesarTab.Controls.Add(this.splitContainer1);
            this.CaesarTab.Controls.Add(this.label1);
            this.CaesarTab.Location = new System.Drawing.Point(4, 22);
            this.CaesarTab.Name = "CaesarTab";
            this.CaesarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaesarTab.Size = new System.Drawing.Size(777, 540);
            this.CaesarTab.TabIndex = 0;
            this.CaesarTab.Text = "Шифр Цезаря";
            this.CaesarTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.LeftCaesarTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.RightCaesarTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(771, 534);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(573, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Зашифровать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(384, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вставить из буфера обмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LeftCaesarTextBox
            // 
            this.LeftCaesarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftCaesarTextBox.Location = new System.Drawing.Point(3, 0);
            this.LeftCaesarTextBox.Multiline = true;
            this.LeftCaesarTextBox.Name = "LeftCaesarTextBox";
            this.LeftCaesarTextBox.Size = new System.Drawing.Size(765, 193);
            this.LeftCaesarTextBox.TabIndex = 0;
            // 
            // RightCaesarTextBox
            // 
            this.RightCaesarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightCaesarTextBox.Location = new System.Drawing.Point(3, 0);
            this.RightCaesarTextBox.Multiline = true;
            this.RightCaesarTextBox.Name = "RightCaesarTextBox";
            this.RightCaesarTextBox.ReadOnly = true;
            this.RightCaesarTextBox.Size = new System.Drawing.Size(765, 223);
            this.RightCaesarTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // VigenereTab
            // 
            this.VigenereTab.Location = new System.Drawing.Point(4, 22);
            this.VigenereTab.Name = "VigenereTab";
            this.VigenereTab.Padding = new System.Windows.Forms.Padding(3);
            this.VigenereTab.Size = new System.Drawing.Size(777, 540);
            this.VigenereTab.TabIndex = 1;
            this.VigenereTab.Text = "Шифр Виженера";
            this.VigenereTab.UseVisualStyleBackColor = true;
            // 
            // DiffieHellmanTab
            // 
            this.DiffieHellmanTab.Location = new System.Drawing.Point(4, 22);
            this.DiffieHellmanTab.Name = "DiffieHellmanTab";
            this.DiffieHellmanTab.Padding = new System.Windows.Forms.Padding(3);
            this.DiffieHellmanTab.Size = new System.Drawing.Size(777, 540);
            this.DiffieHellmanTab.TabIndex = 2;
            this.DiffieHellmanTab.Text = "Протокол Диффи-Хеллмана";
            this.DiffieHellmanTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(573, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Расшифровать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(384, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Копировать в буфер обмена";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Шифровка",
            "Дешифровка"});
            this.comboBox1.Location = new System.Drawing.Point(243, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(144, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шаг";
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CipherTabControl);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CipherForm";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.CipherForm_SizeChanged);
            this.CipherTabControl.ResumeLayout(false);
            this.CaesarTab.ResumeLayout(false);
            this.CaesarTab.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CipherTabControl;
        private System.Windows.Forms.TabPage CaesarTab;
        private System.Windows.Forms.TabPage VigenereTab;
        private System.Windows.Forms.TabPage DiffieHellmanTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LeftCaesarTextBox;
        private System.Windows.Forms.TextBox RightCaesarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

