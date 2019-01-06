namespace DALTUDQL_1660007_1660010_1660136
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBaoCao_SDThuoc = new System.Windows.Forms.Button();
            this.tabBC = new System.Windows.Forms.TabPage();
            this.btnBaoCao_DoanhThu = new System.Windows.Forms.Button();
            this.dataDSThuoc = new System.Windows.Forms.DataGridView();
            this.groupBoxDSThuoc = new System.Windows.Forms.GroupBox();
            this.btnQLT_Xoa = new System.Windows.Forms.Button();
            this.groupBoxTTThuoc = new System.Windows.Forms.GroupBox();
            this.textBoxQLT_DonGia = new System.Windows.Forms.TextBox();
            this.textBoxQLT_SoLuongTon = new System.Windows.Forms.TextBox();
            this.textBoxQLT_DonViTinh = new System.Windows.Forms.TextBox();
            this.lbSoLuongTon = new System.Windows.Forms.Label();
            this.textBoxQLT_TenThuoc = new System.Windows.Forms.TextBox();
            this.lbDonViTinh = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbTenThuoc = new System.Windows.Forms.Label();
            this.btnQLT_Sua = new System.Windows.Forms.Button();
            this.btnQLT_Huy = new System.Windows.Forms.Button();
            this.tabQLT = new System.Windows.Forms.TabPage();
            this.btnQLT_Them = new System.Windows.Forms.Button();
            this.btnQLBN_DSBN = new System.Windows.Forms.Button();
            this.btnQLBN_PKB = new System.Windows.Forms.Button();
            this.tabsFrmMain = new System.Windows.Forms.TabControl();
            this.tabQLBN = new System.Windows.Forms.TabPage();
            this.btnQLBN_DSKB = new System.Windows.Forms.Button();
            this.tabBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSThuoc)).BeginInit();
            this.groupBoxDSThuoc.SuspendLayout();
            this.groupBoxTTThuoc.SuspendLayout();
            this.tabQLT.SuspendLayout();
            this.tabsFrmMain.SuspendLayout();
            this.tabQLBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaoCao_SDThuoc
            // 
            this.btnBaoCao_SDThuoc.Location = new System.Drawing.Point(183, 6);
            this.btnBaoCao_SDThuoc.Name = "btnBaoCao_SDThuoc";
            this.btnBaoCao_SDThuoc.Size = new System.Drawing.Size(171, 48);
            this.btnBaoCao_SDThuoc.TabIndex = 2;
            this.btnBaoCao_SDThuoc.Text = "BÁO CÁO SỬ DỤNG THUỐC";
            this.btnBaoCao_SDThuoc.UseVisualStyleBackColor = true;
            this.btnBaoCao_SDThuoc.Click += new System.EventHandler(this.btnBaoCao_SDThuoc_Click);
            // 
            // tabBC
            // 
            this.tabBC.Controls.Add(this.btnBaoCao_SDThuoc);
            this.tabBC.Controls.Add(this.btnBaoCao_DoanhThu);
            this.tabBC.Location = new System.Drawing.Point(4, 22);
            this.tabBC.Name = "tabBC";
            this.tabBC.Padding = new System.Windows.Forms.Padding(3);
            this.tabBC.Size = new System.Drawing.Size(852, 511);
            this.tabBC.TabIndex = 2;
            this.tabBC.Text = "BÁO CÁO";
            this.tabBC.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao_DoanhThu
            // 
            this.btnBaoCao_DoanhThu.Location = new System.Drawing.Point(6, 6);
            this.btnBaoCao_DoanhThu.Name = "btnBaoCao_DoanhThu";
            this.btnBaoCao_DoanhThu.Size = new System.Drawing.Size(171, 48);
            this.btnBaoCao_DoanhThu.TabIndex = 3;
            this.btnBaoCao_DoanhThu.Text = "BÁO CÁO DANH THU";
            this.btnBaoCao_DoanhThu.UseVisualStyleBackColor = true;
            this.btnBaoCao_DoanhThu.Click += new System.EventHandler(this.btnBaoCao_DoanhThu_Click);
            // 
            // dataDSThuoc
            // 
            this.dataDSThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSThuoc.Location = new System.Drawing.Point(5, 20);
            this.dataDSThuoc.Name = "dataDSThuoc";
            this.dataDSThuoc.Size = new System.Drawing.Size(829, 247);
            this.dataDSThuoc.TabIndex = 0;
            // 
            // groupBoxDSThuoc
            // 
            this.groupBoxDSThuoc.Controls.Add(this.dataDSThuoc);
            this.groupBoxDSThuoc.Location = new System.Drawing.Point(6, 207);
            this.groupBoxDSThuoc.Name = "groupBoxDSThuoc";
            this.groupBoxDSThuoc.Size = new System.Drawing.Size(840, 272);
            this.groupBoxDSThuoc.TabIndex = 38;
            this.groupBoxDSThuoc.TabStop = false;
            this.groupBoxDSThuoc.Text = "Danh sách thuốc";
            // 
            // btnQLT_Xoa
            // 
            this.btnQLT_Xoa.Location = new System.Drawing.Point(430, 168);
            this.btnQLT_Xoa.Name = "btnQLT_Xoa";
            this.btnQLT_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btnQLT_Xoa.TabIndex = 33;
            this.btnQLT_Xoa.Text = "XÓA";
            this.btnQLT_Xoa.UseVisualStyleBackColor = true;
            // 
            // groupBoxTTThuoc
            // 
            this.groupBoxTTThuoc.Controls.Add(this.textBoxQLT_DonGia);
            this.groupBoxTTThuoc.Controls.Add(this.textBoxQLT_SoLuongTon);
            this.groupBoxTTThuoc.Controls.Add(this.textBoxQLT_DonViTinh);
            this.groupBoxTTThuoc.Controls.Add(this.lbSoLuongTon);
            this.groupBoxTTThuoc.Controls.Add(this.textBoxQLT_TenThuoc);
            this.groupBoxTTThuoc.Controls.Add(this.lbDonViTinh);
            this.groupBoxTTThuoc.Controls.Add(this.lbDonGia);
            this.groupBoxTTThuoc.Controls.Add(this.lbTenThuoc);
            this.groupBoxTTThuoc.Location = new System.Drawing.Point(117, 61);
            this.groupBoxTTThuoc.Name = "groupBoxTTThuoc";
            this.groupBoxTTThuoc.Size = new System.Drawing.Size(624, 91);
            this.groupBoxTTThuoc.TabIndex = 37;
            this.groupBoxTTThuoc.TabStop = false;
            this.groupBoxTTThuoc.Text = "Thông tin";
            // 
            // textBoxQLT_DonGia
            // 
            this.textBoxQLT_DonGia.Location = new System.Drawing.Point(147, 57);
            this.textBoxQLT_DonGia.Name = "textBoxQLT_DonGia";
            this.textBoxQLT_DonGia.Size = new System.Drawing.Size(166, 20);
            this.textBoxQLT_DonGia.TabIndex = 1;
            // 
            // textBoxQLT_SoLuongTon
            // 
            this.textBoxQLT_SoLuongTon.Location = new System.Drawing.Point(436, 57);
            this.textBoxQLT_SoLuongTon.Name = "textBoxQLT_SoLuongTon";
            this.textBoxQLT_SoLuongTon.Size = new System.Drawing.Size(87, 20);
            this.textBoxQLT_SoLuongTon.TabIndex = 1;
            this.textBoxQLT_SoLuongTon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxQLT_DonViTinh
            // 
            this.textBoxQLT_DonViTinh.Location = new System.Drawing.Point(436, 28);
            this.textBoxQLT_DonViTinh.Name = "textBoxQLT_DonViTinh";
            this.textBoxQLT_DonViTinh.Size = new System.Drawing.Size(87, 20);
            this.textBoxQLT_DonViTinh.TabIndex = 1;
            // 
            // lbSoLuongTon
            // 
            this.lbSoLuongTon.AutoSize = true;
            this.lbSoLuongTon.Location = new System.Drawing.Point(350, 60);
            this.lbSoLuongTon.Name = "lbSoLuongTon";
            this.lbSoLuongTon.Size = new System.Drawing.Size(75, 13);
            this.lbSoLuongTon.TabIndex = 0;
            this.lbSoLuongTon.Text = "Số Lượng Tồn";
            this.lbSoLuongTon.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxQLT_TenThuoc
            // 
            this.textBoxQLT_TenThuoc.Location = new System.Drawing.Point(147, 28);
            this.textBoxQLT_TenThuoc.Name = "textBoxQLT_TenThuoc";
            this.textBoxQLT_TenThuoc.Size = new System.Drawing.Size(166, 20);
            this.textBoxQLT_TenThuoc.TabIndex = 1;
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.AutoSize = true;
            this.lbDonViTinh.Location = new System.Drawing.Point(350, 31);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(60, 13);
            this.lbDonViTinh.TabIndex = 0;
            this.lbDonViTinh.Text = "Đơn vị tính";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(77, 60);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(44, 13);
            this.lbDonGia.TabIndex = 0;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // lbTenThuoc
            // 
            this.lbTenThuoc.AutoSize = true;
            this.lbTenThuoc.Location = new System.Drawing.Point(77, 31);
            this.lbTenThuoc.Name = "lbTenThuoc";
            this.lbTenThuoc.Size = new System.Drawing.Size(56, 13);
            this.lbTenThuoc.TabIndex = 0;
            this.lbTenThuoc.Text = "Tên thuốc";
            // 
            // btnQLT_Sua
            // 
            this.btnQLT_Sua.Location = new System.Drawing.Point(349, 168);
            this.btnQLT_Sua.Name = "btnQLT_Sua";
            this.btnQLT_Sua.Size = new System.Drawing.Size(75, 23);
            this.btnQLT_Sua.TabIndex = 35;
            this.btnQLT_Sua.Text = "SỬA";
            this.btnQLT_Sua.UseVisualStyleBackColor = true;
            // 
            // btnQLT_Huy
            // 
            this.btnQLT_Huy.Location = new System.Drawing.Point(511, 168);
            this.btnQLT_Huy.Name = "btnQLT_Huy";
            this.btnQLT_Huy.Size = new System.Drawing.Size(75, 23);
            this.btnQLT_Huy.TabIndex = 36;
            this.btnQLT_Huy.Text = "HỦY";
            this.btnQLT_Huy.UseVisualStyleBackColor = true;
            // 
            // tabQLT
            // 
            this.tabQLT.Controls.Add(this.btnQLT_Sua);
            this.tabQLT.Controls.Add(this.btnQLT_Huy);
            this.tabQLT.Controls.Add(this.btnQLT_Them);
            this.tabQLT.Controls.Add(this.btnQLT_Xoa);
            this.tabQLT.Controls.Add(this.groupBoxTTThuoc);
            this.tabQLT.Controls.Add(this.groupBoxDSThuoc);
            this.tabQLT.Location = new System.Drawing.Point(4, 22);
            this.tabQLT.Name = "tabQLT";
            this.tabQLT.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLT.Size = new System.Drawing.Size(852, 511);
            this.tabQLT.TabIndex = 1;
            this.tabQLT.Text = "QUẢN LÝ THUỐC";
            this.tabQLT.UseVisualStyleBackColor = true;
            // 
            // btnQLT_Them
            // 
            this.btnQLT_Them.Location = new System.Drawing.Point(268, 168);
            this.btnQLT_Them.Name = "btnQLT_Them";
            this.btnQLT_Them.Size = new System.Drawing.Size(75, 23);
            this.btnQLT_Them.TabIndex = 32;
            this.btnQLT_Them.Text = "THÊM";
            this.btnQLT_Them.UseVisualStyleBackColor = true;
            // 
            // btnQLBN_DSBN
            // 
            this.btnQLBN_DSBN.Location = new System.Drawing.Point(360, 6);
            this.btnQLBN_DSBN.Name = "btnQLBN_DSBN";
            this.btnQLBN_DSBN.Size = new System.Drawing.Size(171, 48);
            this.btnQLBN_DSBN.TabIndex = 0;
            this.btnQLBN_DSBN.Text = "DANH SÁCH BỆNH NHÂN";
            this.btnQLBN_DSBN.UseVisualStyleBackColor = true;
            this.btnQLBN_DSBN.Click += new System.EventHandler(this.btnQLBN_DSBN_Click);
            // 
            // btnQLBN_PKB
            // 
            this.btnQLBN_PKB.Location = new System.Drawing.Point(183, 6);
            this.btnQLBN_PKB.Name = "btnQLBN_PKB";
            this.btnQLBN_PKB.Size = new System.Drawing.Size(171, 48);
            this.btnQLBN_PKB.TabIndex = 0;
            this.btnQLBN_PKB.Text = "PHIẾU KHÁM BỆNH";
            this.btnQLBN_PKB.UseVisualStyleBackColor = true;
            this.btnQLBN_PKB.Click += new System.EventHandler(this.btnQLBN_PKB_Click);
            // 
            // tabsFrmMain
            // 
            this.tabsFrmMain.Controls.Add(this.tabQLBN);
            this.tabsFrmMain.Controls.Add(this.tabQLT);
            this.tabsFrmMain.Controls.Add(this.tabBC);
            this.tabsFrmMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabsFrmMain.Location = new System.Drawing.Point(12, 12);
            this.tabsFrmMain.Name = "tabsFrmMain";
            this.tabsFrmMain.SelectedIndex = 0;
            this.tabsFrmMain.Size = new System.Drawing.Size(860, 537);
            this.tabsFrmMain.TabIndex = 1;
            // 
            // tabQLBN
            // 
            this.tabQLBN.Controls.Add(this.btnQLBN_DSKB);
            this.tabQLBN.Controls.Add(this.btnQLBN_DSBN);
            this.tabQLBN.Controls.Add(this.btnQLBN_PKB);
            this.tabQLBN.Location = new System.Drawing.Point(4, 22);
            this.tabQLBN.Name = "tabQLBN";
            this.tabQLBN.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLBN.Size = new System.Drawing.Size(852, 511);
            this.tabQLBN.TabIndex = 0;
            this.tabQLBN.Text = "QUẢN LÝ BỆNH NHÂN";
            this.tabQLBN.UseVisualStyleBackColor = true;
            // 
            // btnQLBN_DSKB
            // 
            this.btnQLBN_DSKB.Location = new System.Drawing.Point(6, 6);
            this.btnQLBN_DSKB.Name = "btnQLBN_DSKB";
            this.btnQLBN_DSKB.Size = new System.Drawing.Size(171, 48);
            this.btnQLBN_DSKB.TabIndex = 0;
            this.btnQLBN_DSKB.Text = "DANH SÁCH KHÁM BỆNH";
            this.btnQLBN_DSKB.UseVisualStyleBackColor = true;
            this.btnQLBN_DSKB.Click += new System.EventHandler(this.btnQLBN_DSKB_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabsFrmMain);
            this.Name = "formMain";
            this.Text = "Quản lý phòng mạch";
            this.tabBC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSThuoc)).EndInit();
            this.groupBoxDSThuoc.ResumeLayout(false);
            this.groupBoxTTThuoc.ResumeLayout(false);
            this.groupBoxTTThuoc.PerformLayout();
            this.tabQLT.ResumeLayout(false);
            this.tabsFrmMain.ResumeLayout(false);
            this.tabQLBN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBaoCao_SDThuoc;
        private System.Windows.Forms.TabPage tabBC;
        private System.Windows.Forms.Button btnBaoCao_DoanhThu;
        private System.Windows.Forms.DataGridView dataDSThuoc;
        private System.Windows.Forms.GroupBox groupBoxDSThuoc;
        private System.Windows.Forms.Button btnQLT_Xoa;
        private System.Windows.Forms.GroupBox groupBoxTTThuoc;
        private System.Windows.Forms.TextBox textBoxQLT_DonGia;
        private System.Windows.Forms.TextBox textBoxQLT_DonViTinh;
        private System.Windows.Forms.TextBox textBoxQLT_TenThuoc;
        private System.Windows.Forms.Label lbDonViTinh;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTenThuoc;
        private System.Windows.Forms.Button btnQLT_Sua;
        private System.Windows.Forms.Button btnQLT_Huy;
        private System.Windows.Forms.TabPage tabQLT;
        private System.Windows.Forms.Button btnQLT_Them;
        private System.Windows.Forms.Button btnQLBN_DSBN;
        private System.Windows.Forms.Button btnQLBN_PKB;
        private System.Windows.Forms.TabControl tabsFrmMain;
        private System.Windows.Forms.TabPage tabQLBN;
        private System.Windows.Forms.Button btnQLBN_DSKB;
        private System.Windows.Forms.TextBox textBoxQLT_SoLuongTon;
        private System.Windows.Forms.Label lbSoLuongTon;
    }
}

