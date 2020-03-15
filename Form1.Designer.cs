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
            this.CaesarStepLabel = new System.Windows.Forms.Label();
            this.CaesarProcessModeComboBox = new System.Windows.Forms.ComboBox();
            this.CaesarBeforeProcessButton = new System.Windows.Forms.Button();
            this.CaesarPasteButton = new System.Windows.Forms.Button();
            this.CaesarBeforeProccesTextBox = new System.Windows.Forms.TextBox();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.CaesarCopyButton = new System.Windows.Forms.Button();
            this.CaesarAfterProcessTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VigenereTab = new System.Windows.Forms.TabPage();
            this.DiffieHellmanTab = new System.Windows.Forms.TabPage();
            this.CaesarStepUpDown = new System.Windows.Forms.NumericUpDown();
            this.CipherTabControl.SuspendLayout();
            this.CaesarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaesarStepUpDown)).BeginInit();
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
            this.CipherTabControl.Size = new System.Drawing.Size(789, 566);
            this.CipherTabControl.TabIndex = 0;
            // 
            // CaesarTab
            // 
            this.CaesarTab.Controls.Add(this.splitContainer1);
            this.CaesarTab.Controls.Add(this.label1);
            this.CaesarTab.Location = new System.Drawing.Point(4, 22);
            this.CaesarTab.Name = "CaesarTab";
            this.CaesarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaesarTab.Size = new System.Drawing.Size(781, 540);
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
            this.splitContainer1.Panel1.Controls.Add(this.CaesarStepUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.CaesarStepLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CaesarProcessModeComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.CaesarBeforeProcessButton);
            this.splitContainer1.Panel1.Controls.Add(this.CaesarPasteButton);
            this.splitContainer1.Panel1.Controls.Add(this.CaesarBeforeProccesTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SaveToFileButton);
            this.splitContainer1.Panel2.Controls.Add(this.CaesarCopyButton);
            this.splitContainer1.Panel2.Controls.Add(this.CaesarAfterProcessTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(775, 534);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 3;
            // 
            // CaesarStepLabel
            // 
            this.CaesarStepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarStepLabel.AutoSize = true;
            this.CaesarStepLabel.Location = new System.Drawing.Point(229, 201);
            this.CaesarStepLabel.Name = "CaesarStepLabel";
            this.CaesarStepLabel.Size = new System.Drawing.Size(27, 13);
            this.CaesarStepLabel.TabIndex = 5;
            this.CaesarStepLabel.Text = "Шаг";
            // 
            // CaesarProcessModeComboBox
            // 
            this.CaesarProcessModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarProcessModeComboBox.FormattingEnabled = true;
            this.CaesarProcessModeComboBox.Items.AddRange(new object[] {
            "Шифровка",
            "Дешифровка"});
            this.CaesarProcessModeComboBox.Location = new System.Drawing.Point(261, 220);
            this.CaesarProcessModeComboBox.Name = "CaesarProcessModeComboBox";
            this.CaesarProcessModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CaesarProcessModeComboBox.TabIndex = 3;
            this.CaesarProcessModeComboBox.SelectedIndexChanged += new System.EventHandler(this.CaesarProcessModeComboBox_SelectedIndexChanged);
            // 
            // CaesarBeforeProcessButton
            // 
            this.CaesarBeforeProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarBeforeProcessButton.Location = new System.Drawing.Point(577, 199);
            this.CaesarBeforeProcessButton.Name = "CaesarBeforeProcessButton";
            this.CaesarBeforeProcessButton.Size = new System.Drawing.Size(195, 42);
            this.CaesarBeforeProcessButton.TabIndex = 2;
            this.CaesarBeforeProcessButton.Text = "Зашифровать";
            this.CaesarBeforeProcessButton.UseVisualStyleBackColor = true;
            this.CaesarBeforeProcessButton.Click += new System.EventHandler(this.CaesarBeforeProcessButton_Click);
            // 
            // CaesarPasteButton
            // 
            this.CaesarPasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarPasteButton.Location = new System.Drawing.Point(388, 199);
            this.CaesarPasteButton.Name = "CaesarPasteButton";
            this.CaesarPasteButton.Size = new System.Drawing.Size(183, 42);
            this.CaesarPasteButton.TabIndex = 1;
            this.CaesarPasteButton.Text = "Вставить из буфера обмена";
            this.CaesarPasteButton.UseVisualStyleBackColor = true;
            this.CaesarPasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // CaesarBeforeProccesTextBox
            // 
            this.CaesarBeforeProccesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarBeforeProccesTextBox.Location = new System.Drawing.Point(3, 0);
            this.CaesarBeforeProccesTextBox.Multiline = true;
            this.CaesarBeforeProccesTextBox.Name = "CaesarBeforeProccesTextBox";
            this.CaesarBeforeProccesTextBox.Size = new System.Drawing.Size(769, 193);
            this.CaesarBeforeProccesTextBox.TabIndex = 0;
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToFileButton.Enabled = false;
            this.SaveToFileButton.Location = new System.Drawing.Point(577, 229);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(195, 42);
            this.SaveToFileButton.TabIndex = 4;
            this.SaveToFileButton.Text = "Сохранить в файл";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            // 
            // CaesarCopyButton
            // 
            this.CaesarCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarCopyButton.Enabled = false;
            this.CaesarCopyButton.Location = new System.Drawing.Point(388, 229);
            this.CaesarCopyButton.Name = "CaesarCopyButton";
            this.CaesarCopyButton.Size = new System.Drawing.Size(183, 42);
            this.CaesarCopyButton.TabIndex = 3;
            this.CaesarCopyButton.Text = "Копировать в буфер обмена";
            this.CaesarCopyButton.UseVisualStyleBackColor = true;
            this.CaesarCopyButton.Click += new System.EventHandler(this.CaesarCopyButton_Click);
            // 
            // CaesarAfterProcessTextBox
            // 
            this.CaesarAfterProcessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarAfterProcessTextBox.Location = new System.Drawing.Point(3, 0);
            this.CaesarAfterProcessTextBox.Multiline = true;
            this.CaesarAfterProcessTextBox.Name = "CaesarAfterProcessTextBox";
            this.CaesarAfterProcessTextBox.ReadOnly = true;
            this.CaesarAfterProcessTextBox.Size = new System.Drawing.Size(769, 223);
            this.CaesarAfterProcessTextBox.TabIndex = 1;
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
            // CaesarStepUpDown
            // 
            this.CaesarStepUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarStepUpDown.Location = new System.Drawing.Point(261, 199);
            this.CaesarStepUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.CaesarStepUpDown.Name = "CaesarStepUpDown";
            this.CaesarStepUpDown.Size = new System.Drawing.Size(121, 20);
            this.CaesarStepUpDown.TabIndex = 6;
            this.CaesarStepUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            ((System.ComponentModel.ISupportInitialize)(this.CaesarStepUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CipherTabControl;
        private System.Windows.Forms.TabPage CaesarTab;
        private System.Windows.Forms.TabPage VigenereTab;
        private System.Windows.Forms.TabPage DiffieHellmanTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CaesarBeforeProcessButton;
        private System.Windows.Forms.Button CaesarPasteButton;
        private System.Windows.Forms.TextBox CaesarBeforeProccesTextBox;
        private System.Windows.Forms.TextBox CaesarAfterProcessTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.Button CaesarCopyButton;
        private System.Windows.Forms.ComboBox CaesarProcessModeComboBox;
        private System.Windows.Forms.Label CaesarStepLabel;
        private System.Windows.Forms.NumericUpDown CaesarStepUpDown;
    }
}

