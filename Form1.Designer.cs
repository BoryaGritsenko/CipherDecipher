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
            this.CaesarSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CaesarStepUpDown = new System.Windows.Forms.NumericUpDown();
            this.CaesarStepLabel = new System.Windows.Forms.Label();
            this.CaesarProcessModeComboBox = new System.Windows.Forms.ComboBox();
            this.CaesarBeforeProcessButton = new System.Windows.Forms.Button();
            this.CaesarPasteButton = new System.Windows.Forms.Button();
            this.CaesarBeforeProcessTextBox = new System.Windows.Forms.TextBox();
            this.CaesarSaveToFileButton = new System.Windows.Forms.Button();
            this.CaesarCopyButton = new System.Windows.Forms.Button();
            this.CaesarAfterProcessTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VigenereTab = new System.Windows.Forms.TabPage();
            this.VigenereSplitContainer = new System.Windows.Forms.SplitContainer();
            this.VigenereKeyLabel = new System.Windows.Forms.Label();
            this.VigenereKeyTextBox = new System.Windows.Forms.TextBox();
            this.VigenereProcessModeComboBox = new System.Windows.Forms.ComboBox();
            this.VigenereBeforeProcessButton = new System.Windows.Forms.Button();
            this.VigenereBeforeProcessTextBox = new System.Windows.Forms.TextBox();
            this.VigenerePasteButton = new System.Windows.Forms.Button();
            this.VigenereAfterProcessTextBox = new System.Windows.Forms.TextBox();
            this.VigenereCopyButton = new System.Windows.Forms.Button();
            this.VigenereSaveToFileButton = new System.Windows.Forms.Button();
            this.DiffieHellmanTab = new System.Windows.Forms.TabPage();
            this.DiffieHellmanKeySplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiffieHellmanCaptionLabel = new System.Windows.Forms.Label();
            this.DiffieHellmanInsertUpDown = new System.Windows.Forms.NumericUpDown();
            this.DiffieHellmanButton = new System.Windows.Forms.Button();
            this.DiffieHellmanResultCaptionLabel = new System.Windows.Forms.Label();
            this.DiffieHellmanResultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiffieHellmanGeneratorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DiffieHellmanPrimeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DiffieHellmanPartnerKeyResultUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DiffieHellmanCalcPartnerKeyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DiffieHellmanOwnKeyUpDown = new System.Windows.Forms.NumericUpDown();
            this.DiffieHellmanOwnKeyResultLabel = new System.Windows.Forms.Label();
            this.DiffieHellmanCalcOwnKeyButton = new System.Windows.Forms.Button();
            this.DiffieHellmanPartnerKeyUpDown = new System.Windows.Forms.NumericUpDown();
            this.DiffieHellmanCollapseKeyButton = new System.Windows.Forms.Button();
            this.CipherTabControl.SuspendLayout();
            this.CaesarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaesarSplitContainer)).BeginInit();
            this.CaesarSplitContainer.Panel1.SuspendLayout();
            this.CaesarSplitContainer.Panel2.SuspendLayout();
            this.CaesarSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaesarStepUpDown)).BeginInit();
            this.VigenereTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VigenereSplitContainer)).BeginInit();
            this.VigenereSplitContainer.Panel1.SuspendLayout();
            this.VigenereSplitContainer.Panel2.SuspendLayout();
            this.VigenereSplitContainer.SuspendLayout();
            this.DiffieHellmanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanKeySplitContainer)).BeginInit();
            this.DiffieHellmanKeySplitContainer.Panel1.SuspendLayout();
            this.DiffieHellmanKeySplitContainer.Panel2.SuspendLayout();
            this.DiffieHellmanKeySplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanInsertUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanPartnerKeyResultUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanOwnKeyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanPartnerKeyUpDown)).BeginInit();
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
            this.CaesarTab.Controls.Add(this.CaesarSplitContainer);
            this.CaesarTab.Controls.Add(this.label1);
            this.CaesarTab.Location = new System.Drawing.Point(4, 22);
            this.CaesarTab.Name = "CaesarTab";
            this.CaesarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaesarTab.Size = new System.Drawing.Size(781, 540);
            this.CaesarTab.TabIndex = 0;
            this.CaesarTab.Text = "Шифр Цезаря";
            this.CaesarTab.UseVisualStyleBackColor = true;
            this.CaesarTab.SizeChanged += new System.EventHandler(this.CaesarTab_SizeChanged);
            // 
            // CaesarSplitContainer
            // 
            this.CaesarSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarSplitContainer.IsSplitterFixed = true;
            this.CaesarSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.CaesarSplitContainer.Name = "CaesarSplitContainer";
            this.CaesarSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // CaesarSplitContainer.Panel1
            // 
            this.CaesarSplitContainer.Panel1.Controls.Add(this.CaesarStepUpDown);
            this.CaesarSplitContainer.Panel1.Controls.Add(this.CaesarStepLabel);
            this.CaesarSplitContainer.Panel1.Controls.Add(this.CaesarProcessModeComboBox);
            this.CaesarSplitContainer.Panel1.Controls.Add(this.CaesarBeforeProcessButton);
            this.CaesarSplitContainer.Panel1.Controls.Add(this.CaesarPasteButton);
            this.CaesarSplitContainer.Panel1.Controls.Add(this.CaesarBeforeProcessTextBox);
            // 
            // CaesarSplitContainer.Panel2
            // 
            this.CaesarSplitContainer.Panel2.Controls.Add(this.CaesarSaveToFileButton);
            this.CaesarSplitContainer.Panel2.Controls.Add(this.CaesarCopyButton);
            this.CaesarSplitContainer.Panel2.Controls.Add(this.CaesarAfterProcessTextBox);
            this.CaesarSplitContainer.Size = new System.Drawing.Size(775, 534);
            this.CaesarSplitContainer.SplitterDistance = 250;
            this.CaesarSplitContainer.TabIndex = 3;
            // 
            // CaesarStepUpDown
            // 
            this.CaesarStepUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarStepUpDown.Location = new System.Drawing.Point(259, 199);
            this.CaesarStepUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.CaesarStepUpDown.Name = "CaesarStepUpDown";
            this.CaesarStepUpDown.Size = new System.Drawing.Size(123, 20);
            this.CaesarStepUpDown.TabIndex = 6;
            this.CaesarStepUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaesarStepLabel
            // 
            this.CaesarStepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarStepLabel.AutoSize = true;
            this.CaesarStepLabel.Location = new System.Drawing.Point(229, 202);
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
            this.CaesarProcessModeComboBox.Location = new System.Drawing.Point(259, 220);
            this.CaesarProcessModeComboBox.Name = "CaesarProcessModeComboBox";
            this.CaesarProcessModeComboBox.Size = new System.Drawing.Size(123, 21);
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
            this.CaesarPasteButton.Click += new System.EventHandler(this.CaesarPasteButton_Click);
            // 
            // CaesarBeforeProcessTextBox
            // 
            this.CaesarBeforeProcessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarBeforeProcessTextBox.Location = new System.Drawing.Point(3, 0);
            this.CaesarBeforeProcessTextBox.Multiline = true;
            this.CaesarBeforeProcessTextBox.Name = "CaesarBeforeProcessTextBox";
            this.CaesarBeforeProcessTextBox.Size = new System.Drawing.Size(769, 193);
            this.CaesarBeforeProcessTextBox.TabIndex = 0;
            // 
            // CaesarSaveToFileButton
            // 
            this.CaesarSaveToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CaesarSaveToFileButton.Enabled = false;
            this.CaesarSaveToFileButton.Location = new System.Drawing.Point(577, 229);
            this.CaesarSaveToFileButton.Name = "CaesarSaveToFileButton";
            this.CaesarSaveToFileButton.Size = new System.Drawing.Size(195, 42);
            this.CaesarSaveToFileButton.TabIndex = 4;
            this.CaesarSaveToFileButton.Text = "Сохранить в файл";
            this.CaesarSaveToFileButton.UseVisualStyleBackColor = true;
            this.CaesarSaveToFileButton.Click += new System.EventHandler(this.CaesarSaveToFileButton_Click);
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
            this.CaesarAfterProcessTextBox.TextChanged += new System.EventHandler(this.CaesarAfterProcessTextBox_TextChanged);
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
            this.VigenereTab.Controls.Add(this.VigenereSplitContainer);
            this.VigenereTab.Location = new System.Drawing.Point(4, 22);
            this.VigenereTab.Name = "VigenereTab";
            this.VigenereTab.Padding = new System.Windows.Forms.Padding(3);
            this.VigenereTab.Size = new System.Drawing.Size(781, 540);
            this.VigenereTab.TabIndex = 1;
            this.VigenereTab.Text = "Шифр Виженера";
            this.VigenereTab.UseVisualStyleBackColor = true;
            this.VigenereTab.SizeChanged += new System.EventHandler(this.VigenereTab_SizeChanged);
            // 
            // VigenereSplitContainer
            // 
            this.VigenereSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VigenereSplitContainer.IsSplitterFixed = true;
            this.VigenereSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.VigenereSplitContainer.Name = "VigenereSplitContainer";
            this.VigenereSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // VigenereSplitContainer.Panel1
            // 
            this.VigenereSplitContainer.Panel1.Controls.Add(this.VigenereKeyLabel);
            this.VigenereSplitContainer.Panel1.Controls.Add(this.VigenereKeyTextBox);
            this.VigenereSplitContainer.Panel1.Controls.Add(this.VigenereProcessModeComboBox);
            this.VigenereSplitContainer.Panel1.Controls.Add(this.VigenereBeforeProcessButton);
            this.VigenereSplitContainer.Panel1.Controls.Add(this.VigenereBeforeProcessTextBox);
            this.VigenereSplitContainer.Panel1.Controls.Add(this.VigenerePasteButton);
            // 
            // VigenereSplitContainer.Panel2
            // 
            this.VigenereSplitContainer.Panel2.Controls.Add(this.VigenereAfterProcessTextBox);
            this.VigenereSplitContainer.Panel2.Controls.Add(this.VigenereCopyButton);
            this.VigenereSplitContainer.Panel2.Controls.Add(this.VigenereSaveToFileButton);
            this.VigenereSplitContainer.Size = new System.Drawing.Size(775, 534);
            this.VigenereSplitContainer.SplitterDistance = 250;
            this.VigenereSplitContainer.TabIndex = 0;
            // 
            // VigenereKeyLabel
            // 
            this.VigenereKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenereKeyLabel.AutoSize = true;
            this.VigenereKeyLabel.Location = new System.Drawing.Point(223, 202);
            this.VigenereKeyLabel.Name = "VigenereKeyLabel";
            this.VigenereKeyLabel.Size = new System.Drawing.Size(33, 13);
            this.VigenereKeyLabel.TabIndex = 11;
            this.VigenereKeyLabel.Text = "Ключ";
            // 
            // VigenereKeyTextBox
            // 
            this.VigenereKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenereKeyTextBox.Location = new System.Drawing.Point(259, 199);
            this.VigenereKeyTextBox.Name = "VigenereKeyTextBox";
            this.VigenereKeyTextBox.Size = new System.Drawing.Size(123, 20);
            this.VigenereKeyTextBox.TabIndex = 10;
            // 
            // VigenereProcessModeComboBox
            // 
            this.VigenereProcessModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenereProcessModeComboBox.FormattingEnabled = true;
            this.VigenereProcessModeComboBox.Items.AddRange(new object[] {
            "Шифровка",
            "Дешифровка"});
            this.VigenereProcessModeComboBox.Location = new System.Drawing.Point(259, 220);
            this.VigenereProcessModeComboBox.Name = "VigenereProcessModeComboBox";
            this.VigenereProcessModeComboBox.Size = new System.Drawing.Size(123, 21);
            this.VigenereProcessModeComboBox.TabIndex = 9;
            this.VigenereProcessModeComboBox.SelectedIndexChanged += new System.EventHandler(this.VigenereProcessModeComboBox_SelectedIndexChanged);
            // 
            // VigenereBeforeProcessButton
            // 
            this.VigenereBeforeProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenereBeforeProcessButton.Location = new System.Drawing.Point(577, 199);
            this.VigenereBeforeProcessButton.Name = "VigenereBeforeProcessButton";
            this.VigenereBeforeProcessButton.Size = new System.Drawing.Size(195, 42);
            this.VigenereBeforeProcessButton.TabIndex = 8;
            this.VigenereBeforeProcessButton.Text = "Зашифровать";
            this.VigenereBeforeProcessButton.UseVisualStyleBackColor = true;
            this.VigenereBeforeProcessButton.Click += new System.EventHandler(this.VigenereBeforeProcessButton_Click);
            // 
            // VigenereBeforeProcessTextBox
            // 
            this.VigenereBeforeProcessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenereBeforeProcessTextBox.Location = new System.Drawing.Point(3, 0);
            this.VigenereBeforeProcessTextBox.Multiline = true;
            this.VigenereBeforeProcessTextBox.Name = "VigenereBeforeProcessTextBox";
            this.VigenereBeforeProcessTextBox.Size = new System.Drawing.Size(769, 193);
            this.VigenereBeforeProcessTextBox.TabIndex = 5;
            // 
            // VigenerePasteButton
            // 
            this.VigenerePasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenerePasteButton.Location = new System.Drawing.Point(388, 199);
            this.VigenerePasteButton.Name = "VigenerePasteButton";
            this.VigenerePasteButton.Size = new System.Drawing.Size(183, 42);
            this.VigenerePasteButton.TabIndex = 6;
            this.VigenerePasteButton.Text = "Вставить из буфера обмена";
            this.VigenerePasteButton.UseVisualStyleBackColor = true;
            this.VigenerePasteButton.Click += new System.EventHandler(this.VigenerePasteButton_Click);
            // 
            // VigenereAfterProcessTextBox
            // 
            this.VigenereAfterProcessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenereAfterProcessTextBox.Location = new System.Drawing.Point(3, 0);
            this.VigenereAfterProcessTextBox.Multiline = true;
            this.VigenereAfterProcessTextBox.Name = "VigenereAfterProcessTextBox";
            this.VigenereAfterProcessTextBox.ReadOnly = true;
            this.VigenereAfterProcessTextBox.Size = new System.Drawing.Size(769, 223);
            this.VigenereAfterProcessTextBox.TabIndex = 7;
            this.VigenereAfterProcessTextBox.TextChanged += new System.EventHandler(this.VigenereAfterProcessTextBox_TextChanged);
            // 
            // VigenereCopyButton
            // 
            this.VigenereCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenereCopyButton.Enabled = false;
            this.VigenereCopyButton.Location = new System.Drawing.Point(388, 229);
            this.VigenereCopyButton.Name = "VigenereCopyButton";
            this.VigenereCopyButton.Size = new System.Drawing.Size(183, 42);
            this.VigenereCopyButton.TabIndex = 9;
            this.VigenereCopyButton.Text = "Копировать в буфер обмена";
            this.VigenereCopyButton.UseVisualStyleBackColor = true;
            this.VigenereCopyButton.Click += new System.EventHandler(this.VigenereCopyButton_Click);
            // 
            // VigenereSaveToFileButton
            // 
            this.VigenereSaveToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VigenereSaveToFileButton.Enabled = false;
            this.VigenereSaveToFileButton.Location = new System.Drawing.Point(577, 229);
            this.VigenereSaveToFileButton.Name = "VigenereSaveToFileButton";
            this.VigenereSaveToFileButton.Size = new System.Drawing.Size(195, 42);
            this.VigenereSaveToFileButton.TabIndex = 10;
            this.VigenereSaveToFileButton.Text = "Сохранить в файл";
            this.VigenereSaveToFileButton.UseVisualStyleBackColor = true;
            this.VigenereSaveToFileButton.Click += new System.EventHandler(this.VigenereSaveToFile_Click);
            // 
            // DiffieHellmanTab
            // 
            this.DiffieHellmanTab.Controls.Add(this.DiffieHellmanKeySplitContainer);
            this.DiffieHellmanTab.Location = new System.Drawing.Point(4, 22);
            this.DiffieHellmanTab.Name = "DiffieHellmanTab";
            this.DiffieHellmanTab.Padding = new System.Windows.Forms.Padding(3);
            this.DiffieHellmanTab.Size = new System.Drawing.Size(781, 540);
            this.DiffieHellmanTab.TabIndex = 2;
            this.DiffieHellmanTab.Text = "Протокол Диффи-Хеллмана";
            this.DiffieHellmanTab.UseVisualStyleBackColor = true;
            this.DiffieHellmanTab.SizeChanged += new System.EventHandler(this.DiffieHellmanTab_SizeChanged);
            // 
            // DiffieHellmanKeySplitContainer
            // 
            this.DiffieHellmanKeySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiffieHellmanKeySplitContainer.IsSplitterFixed = true;
            this.DiffieHellmanKeySplitContainer.Location = new System.Drawing.Point(3, 3);
            this.DiffieHellmanKeySplitContainer.Name = "DiffieHellmanKeySplitContainer";
            // 
            // DiffieHellmanKeySplitContainer.Panel1
            // 
            this.DiffieHellmanKeySplitContainer.Panel1.Controls.Add(this.panel1);
            // 
            // DiffieHellmanKeySplitContainer.Panel2
            // 
            this.DiffieHellmanKeySplitContainer.Panel2.Controls.Add(this.DiffieHellmanCollapseKeyButton);
            this.DiffieHellmanKeySplitContainer.Size = new System.Drawing.Size(775, 534);
            this.DiffieHellmanKeySplitContainer.SplitterDistance = 210;
            this.DiffieHellmanKeySplitContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 534);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 111);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сравнение закрытых ключей";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DiffieHellmanCaptionLabel);
            this.groupBox1.Controls.Add(this.DiffieHellmanInsertUpDown);
            this.groupBox1.Controls.Add(this.DiffieHellmanButton);
            this.groupBox1.Controls.Add(this.DiffieHellmanResultCaptionLabel);
            this.groupBox1.Controls.Add(this.DiffieHellmanResultLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DiffieHellmanGeneratorTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DiffieHellmanPrimeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 201);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Открытый ключ";
            // 
            // DiffieHellmanCaptionLabel
            // 
            this.DiffieHellmanCaptionLabel.AutoSize = true;
            this.DiffieHellmanCaptionLabel.Location = new System.Drawing.Point(6, 16);
            this.DiffieHellmanCaptionLabel.Name = "DiffieHellmanCaptionLabel";
            this.DiffieHellmanCaptionLabel.Size = new System.Drawing.Size(166, 13);
            this.DiffieHellmanCaptionLabel.TabIndex = 13;
            this.DiffieHellmanCaptionLabel.Text = "Сгенерировать ключ  3 до 2000";
            // 
            // DiffieHellmanInsertUpDown
            // 
            this.DiffieHellmanInsertUpDown.Location = new System.Drawing.Point(9, 42);
            this.DiffieHellmanInsertUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.DiffieHellmanInsertUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DiffieHellmanInsertUpDown.Name = "DiffieHellmanInsertUpDown";
            this.DiffieHellmanInsertUpDown.Size = new System.Drawing.Size(75, 20);
            this.DiffieHellmanInsertUpDown.TabIndex = 21;
            this.DiffieHellmanInsertUpDown.TabStop = false;
            this.DiffieHellmanInsertUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiffieHellmanInsertUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // DiffieHellmanButton
            // 
            this.DiffieHellmanButton.Location = new System.Drawing.Point(90, 42);
            this.DiffieHellmanButton.Name = "DiffieHellmanButton";
            this.DiffieHellmanButton.Size = new System.Drawing.Size(80, 20);
            this.DiffieHellmanButton.TabIndex = 12;
            this.DiffieHellmanButton.Text = "Отправить";
            this.DiffieHellmanButton.UseVisualStyleBackColor = true;
            this.DiffieHellmanButton.Click += new System.EventHandler(this.DiffieHellmanButton_Click);
            // 
            // DiffieHellmanResultCaptionLabel
            // 
            this.DiffieHellmanResultCaptionLabel.AutoSize = true;
            this.DiffieHellmanResultCaptionLabel.Location = new System.Drawing.Point(13, 172);
            this.DiffieHellmanResultCaptionLabel.Name = "DiffieHellmanResultCaptionLabel";
            this.DiffieHellmanResultCaptionLabel.Size = new System.Drawing.Size(96, 13);
            this.DiffieHellmanResultCaptionLabel.TabIndex = 22;
            this.DiffieHellmanResultCaptionLabel.Text = "Открытый ключ =";
            // 
            // DiffieHellmanResultLabel
            // 
            this.DiffieHellmanResultLabel.AutoSize = true;
            this.DiffieHellmanResultLabel.Location = new System.Drawing.Point(105, 172);
            this.DiffieHellmanResultLabel.Name = "DiffieHellmanResultLabel";
            this.DiffieHellmanResultLabel.Size = new System.Drawing.Size(0, 13);
            this.DiffieHellmanResultLabel.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = " корень";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите открытый ключ";
            // 
            // DiffieHellmanGeneratorTextBox
            // 
            this.DiffieHellmanGeneratorTextBox.Location = new System.Drawing.Point(95, 106);
            this.DiffieHellmanGeneratorTextBox.Name = "DiffieHellmanGeneratorTextBox";
            this.DiffieHellmanGeneratorTextBox.Size = new System.Drawing.Size(43, 20);
            this.DiffieHellmanGeneratorTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "простое число";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Отправить открытый ключ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiffieHellmanPrimeTextBox
            // 
            this.DiffieHellmanPrimeTextBox.Location = new System.Drawing.Point(25, 106);
            this.DiffieHellmanPrimeTextBox.Name = "DiffieHellmanPrimeTextBox";
            this.DiffieHellmanPrimeTextBox.Size = new System.Drawing.Size(42, 20);
            this.DiffieHellmanPrimeTextBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DiffieHellmanPartnerKeyResultUpDown);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DiffieHellmanCalcPartnerKeyButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DiffieHellmanOwnKeyUpDown);
            this.groupBox2.Controls.Add(this.DiffieHellmanOwnKeyResultLabel);
            this.groupBox2.Controls.Add(this.DiffieHellmanCalcOwnKeyButton);
            this.groupBox2.Controls.Add(this.DiffieHellmanPartnerKeyUpDown);
            this.groupBox2.Location = new System.Drawing.Point(6, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 237);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Закрытый ключ";
            // 
            // DiffieHellmanPartnerKeyResultUpDown
            // 
            this.DiffieHellmanPartnerKeyResultUpDown.Location = new System.Drawing.Point(105, 155);
            this.DiffieHellmanPartnerKeyResultUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DiffieHellmanPartnerKeyResultUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiffieHellmanPartnerKeyResultUpDown.Name = "DiffieHellmanPartnerKeyResultUpDown";
            this.DiffieHellmanPartnerKeyResultUpDown.Size = new System.Drawing.Size(59, 20);
            this.DiffieHellmanPartnerKeyResultUpDown.TabIndex = 33;
            this.DiffieHellmanPartnerKeyResultUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Собственный ключ";
            // 
            // DiffieHellmanCalcPartnerKeyButton
            // 
            this.DiffieHellmanCalcPartnerKeyButton.Location = new System.Drawing.Point(9, 151);
            this.DiffieHellmanCalcPartnerKeyButton.Name = "DiffieHellmanCalcPartnerKeyButton";
            this.DiffieHellmanCalcPartnerKeyButton.Size = new System.Drawing.Size(84, 26);
            this.DiffieHellmanCalcPartnerKeyButton.TabIndex = 32;
            this.DiffieHellmanCalcPartnerKeyButton.Text = "Вычислить";
            this.DiffieHellmanCalcPartnerKeyButton.UseVisualStyleBackColor = true;
            this.DiffieHellmanCalcPartnerKeyButton.Click += new System.EventHandler(this.DiffieHellmanCalcPartnerKeyButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Собственный закрытый ключ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Закрытый ключ партнёра";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ключ партнёра";
            // 
            // DiffieHellmanOwnKeyUpDown
            // 
            this.DiffieHellmanOwnKeyUpDown.Location = new System.Drawing.Point(109, 14);
            this.DiffieHellmanOwnKeyUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DiffieHellmanOwnKeyUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiffieHellmanOwnKeyUpDown.Name = "DiffieHellmanOwnKeyUpDown";
            this.DiffieHellmanOwnKeyUpDown.Size = new System.Drawing.Size(59, 20);
            this.DiffieHellmanOwnKeyUpDown.TabIndex = 23;
            this.DiffieHellmanOwnKeyUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DiffieHellmanOwnKeyResultLabel
            // 
            this.DiffieHellmanOwnKeyResultLabel.AutoSize = true;
            this.DiffieHellmanOwnKeyResultLabel.Location = new System.Drawing.Point(104, 104);
            this.DiffieHellmanOwnKeyResultLabel.Name = "DiffieHellmanOwnKeyResultLabel";
            this.DiffieHellmanOwnKeyResultLabel.Size = new System.Drawing.Size(0, 13);
            this.DiffieHellmanOwnKeyResultLabel.TabIndex = 29;
            // 
            // DiffieHellmanCalcOwnKeyButton
            // 
            this.DiffieHellmanCalcOwnKeyButton.Location = new System.Drawing.Point(9, 97);
            this.DiffieHellmanCalcOwnKeyButton.Name = "DiffieHellmanCalcOwnKeyButton";
            this.DiffieHellmanCalcOwnKeyButton.Size = new System.Drawing.Size(84, 26);
            this.DiffieHellmanCalcOwnKeyButton.TabIndex = 30;
            this.DiffieHellmanCalcOwnKeyButton.Text = "Вычислить";
            this.DiffieHellmanCalcOwnKeyButton.UseVisualStyleBackColor = true;
            this.DiffieHellmanCalcOwnKeyButton.Click += new System.EventHandler(this.DiffieHellmanCalcOwnKeyButton_Click);
            // 
            // DiffieHellmanPartnerKeyUpDown
            // 
            this.DiffieHellmanPartnerKeyUpDown.Location = new System.Drawing.Point(109, 40);
            this.DiffieHellmanPartnerKeyUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DiffieHellmanPartnerKeyUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiffieHellmanPartnerKeyUpDown.Name = "DiffieHellmanPartnerKeyUpDown";
            this.DiffieHellmanPartnerKeyUpDown.Size = new System.Drawing.Size(59, 20);
            this.DiffieHellmanPartnerKeyUpDown.TabIndex = 24;
            this.DiffieHellmanPartnerKeyUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DiffieHellmanCollapseKeyButton
            // 
            this.DiffieHellmanCollapseKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DiffieHellmanCollapseKeyButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DiffieHellmanCollapseKeyButton.FlatAppearance.BorderSize = 0;
            this.DiffieHellmanCollapseKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiffieHellmanCollapseKeyButton.Location = new System.Drawing.Point(1, 0);
            this.DiffieHellmanCollapseKeyButton.Name = "DiffieHellmanCollapseKeyButton";
            this.DiffieHellmanCollapseKeyButton.Size = new System.Drawing.Size(23, 533);
            this.DiffieHellmanCollapseKeyButton.TabIndex = 0;
            this.DiffieHellmanCollapseKeyButton.Text = "←←←";
            this.DiffieHellmanCollapseKeyButton.UseVisualStyleBackColor = false;
            this.DiffieHellmanCollapseKeyButton.Click += new System.EventHandler(this.DiffieHellmanCollapseKeyButton_Click);
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CipherTabControl);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CipherForm";
            this.Text = "CipherDecipher";
            this.CipherTabControl.ResumeLayout(false);
            this.CaesarTab.ResumeLayout(false);
            this.CaesarTab.PerformLayout();
            this.CaesarSplitContainer.Panel1.ResumeLayout(false);
            this.CaesarSplitContainer.Panel1.PerformLayout();
            this.CaesarSplitContainer.Panel2.ResumeLayout(false);
            this.CaesarSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaesarSplitContainer)).EndInit();
            this.CaesarSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CaesarStepUpDown)).EndInit();
            this.VigenereTab.ResumeLayout(false);
            this.VigenereSplitContainer.Panel1.ResumeLayout(false);
            this.VigenereSplitContainer.Panel1.PerformLayout();
            this.VigenereSplitContainer.Panel2.ResumeLayout(false);
            this.VigenereSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VigenereSplitContainer)).EndInit();
            this.VigenereSplitContainer.ResumeLayout(false);
            this.DiffieHellmanTab.ResumeLayout(false);
            this.DiffieHellmanKeySplitContainer.Panel1.ResumeLayout(false);
            this.DiffieHellmanKeySplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanKeySplitContainer)).EndInit();
            this.DiffieHellmanKeySplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanInsertUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanPartnerKeyResultUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanOwnKeyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiffieHellmanPartnerKeyUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CipherTabControl;
        private System.Windows.Forms.TabPage CaesarTab;
        private System.Windows.Forms.TabPage VigenereTab;
        private System.Windows.Forms.TabPage DiffieHellmanTab;
        private System.Windows.Forms.SplitContainer CaesarSplitContainer;
        private System.Windows.Forms.Button CaesarBeforeProcessButton;
        private System.Windows.Forms.Button CaesarPasteButton;
        private System.Windows.Forms.TextBox CaesarBeforeProcessTextBox;
        private System.Windows.Forms.TextBox CaesarAfterProcessTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CaesarSaveToFileButton;
        private System.Windows.Forms.Button CaesarCopyButton;
        private System.Windows.Forms.ComboBox CaesarProcessModeComboBox;
        private System.Windows.Forms.Label CaesarStepLabel;
        private System.Windows.Forms.NumericUpDown CaesarStepUpDown;
        private System.Windows.Forms.SplitContainer VigenereSplitContainer;
        private System.Windows.Forms.Button VigenereBeforeProcessButton;
        private System.Windows.Forms.TextBox VigenereBeforeProcessTextBox;
        private System.Windows.Forms.Button VigenerePasteButton;
        private System.Windows.Forms.TextBox VigenereAfterProcessTextBox;
        private System.Windows.Forms.Button VigenereCopyButton;
        private System.Windows.Forms.Button VigenereSaveToFileButton;
        private System.Windows.Forms.TextBox VigenereKeyTextBox;
        private System.Windows.Forms.ComboBox VigenereProcessModeComboBox;
        private System.Windows.Forms.Label VigenereKeyLabel;
        private System.Windows.Forms.SplitContainer DiffieHellmanKeySplitContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiffieHellmanGeneratorTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DiffieHellmanPrimeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DiffieHellmanResultLabel;
        private System.Windows.Forms.Label DiffieHellmanCaptionLabel;
        private System.Windows.Forms.Button DiffieHellmanButton;
        private System.Windows.Forms.NumericUpDown DiffieHellmanInsertUpDown;
        private System.Windows.Forms.Label DiffieHellmanResultCaptionLabel;
        private System.Windows.Forms.Button DiffieHellmanCollapseKeyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DiffieHellmanCalcPartnerKeyButton;
        private System.Windows.Forms.Button DiffieHellmanCalcOwnKeyButton;
        private System.Windows.Forms.Label DiffieHellmanOwnKeyResultLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DiffieHellmanPartnerKeyUpDown;
        private System.Windows.Forms.NumericUpDown DiffieHellmanOwnKeyUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown DiffieHellmanPartnerKeyResultUpDown;
        private System.Windows.Forms.Panel panel1;
    }
}

