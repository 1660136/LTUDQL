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
    public partial class formPKB : Form
    {
        public formPKB()
        {
            InitializeComponent();
        }

        private void btnPKB_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPKB_LapHoaDon_Click(object sender, EventArgs e)
        {
            formHoaDon hoadon = new formHoaDon();
            hoadon.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formPKB_Load(object sender, EventArgs e)
        {
            listViewPKB.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewPKB.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
