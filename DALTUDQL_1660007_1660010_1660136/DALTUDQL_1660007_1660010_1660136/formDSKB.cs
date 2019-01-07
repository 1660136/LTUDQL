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
    public partial class formDSKB : Form
    {
        public formDSKB()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            Provider p = new Provider();
            string strQuery = "loadDSBNinDay";
            p.Connect();
            dt = p.Select(CommandType.StoredProcedure, strQuery);
            dataGridViewDSKB.DataSource = dt;
        }

        private void btnDSKB_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDSKB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formDSKB_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }
        private void formDSKB_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
