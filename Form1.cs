﻿using System;
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
        public CipherForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void CipherForm_SizeChanged(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = ClientSize.Height / 2;
        }
    }
}
