using System;
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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQLBN_DSKB_Click(object sender, EventArgs e)
        {
            formDSKB dskb = new formDSKB();
            dskb.Owner = this;
            dskb.Show();
        }

        private void btnQLBN_PKB_Click(object sender, EventArgs e)
        {
            formPKB pkb = new formPKB();
            pkb.Owner = this;
            pkb.Show();
        }

        private void btnQLBN_DSBN_Click(object sender, EventArgs e)
        {
            formDSBN dsbn = new formDSBN();
            dsbn.Owner = this;
            dsbn.Show();
        }

        private void btnBaoCao_DoanhThu_Click(object sender, EventArgs e)
        {
            formBCDT bcdt = new formBCDT();
            bcdt.Owner = this;
            bcdt.Show();
        }

        private void btnBaoCao_SDThuoc_Click(object sender, EventArgs e)
        {
            formBCSDT bcsdt = new formBCSDT();
            bcsdt.Owner = this;
            bcsdt.Show();
        }
    }
}
