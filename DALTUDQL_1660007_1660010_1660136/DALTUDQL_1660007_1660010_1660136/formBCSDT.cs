﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALTUDQL_1660007_1660010_1660136
{
    public partial class formBCSDT : Form
    {
        public formBCSDT()
        {
            InitializeComponent();
        }

        private void btnBCSDT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formBCSDT_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void formBCSDT_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
