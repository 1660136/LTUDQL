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
            QuanLyThuoc qlT = new QuanLyThuoc();
            DataTable dt = new DataTable();
            dt = qlT.LoadListAvailable();
            dataDSThuoc.DataSource = dt;
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



        private void dataDSThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxQLT_TenThuoc.Text = dataDSThuoc.Rows[1].ToString();
            textBoxQLT_DonViTinh.Text = dataDSThuoc.Rows[2].ToString();
            textBoxQLT_SoLuongTon.Text = dataDSThuoc.Rows[3].ToString();
            textBoxQLT_DonGia.Text = dataDSThuoc.Rows[4].ToString();
        }

        private void btnQLT_Them_Click(object sender, EventArgs e)
        {
            QuanLyThuoc qlT = new QuanLyThuoc();
            Thuoc t = new Thuoc();
            t.themThuoc(009, textBoxQLT_TenThuoc.Text.ToString(), int.Parse(textBoxQLT_DonViTinh.Text.ToString()), int.Parse(textBoxQLT_DonViTinh.Text.ToString()), int.Parse(textBoxQLT_DonGia.Text.ToString()), 0);
            qlT.addMedicine(t);
        }

        private void btnQLT_Sua_Click(object sender, EventArgs e)
        {
            QuanLyThuoc qlT = new QuanLyThuoc();
            Thuoc t = new Thuoc();
            t.themThuoc(010, textBoxQLT_TenThuoc.Text.ToString(), int.Parse(textBoxQLT_DonViTinh.Text.ToString()), int.Parse(textBoxQLT_DonViTinh.Text.ToString()), int.Parse(textBoxQLT_DonGia.Text.ToString()), 0);
            qlT.editMedicine(t);
        }

        private void btnQLT_Xoa_Click(object sender, EventArgs e)
        {
            QuanLyThuoc qlT = new QuanLyThuoc();
            qlT.deleteMedicine(textBoxQLT_TenThuoc.Text.ToString());
        }
    }
}
