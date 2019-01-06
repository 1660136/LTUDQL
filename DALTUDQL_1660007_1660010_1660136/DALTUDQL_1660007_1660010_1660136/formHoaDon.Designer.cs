namespace DALTUDQL_1660007_1660010_1660136
{
    partial class formHoaDon
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
            this.btnHoaDon_Thoat = new System.Windows.Forms.Button();
            this.dateTimeHoaDon_NgayKham = new System.Windows.Forms.DateTimePicker();
            this.textBoxHoaDon_TienThuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHoaDon_Luu = new System.Windows.Forms.Button();
            this.textBoxHoaDon_TienKham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbHoaDon_HoTen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHoaDon_Thoat
            // 
            this.btnHoaDon_Thoat.Location = new System.Drawing.Point(328, 129);
            this.btnHoaDon_Thoat.Name = "btnHoaDon_Thoat";
            this.btnHoaDon_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btnHoaDon_Thoat.TabIndex = 39;
            this.btnHoaDon_Thoat.Text = "THOÁT";
            this.btnHoaDon_Thoat.UseVisualStyleBackColor = true;
            this.btnHoaDon_Thoat.Click += new System.EventHandler(this.btnHoaDon_Thoat_Click);
            // 
            // dateTimeHoaDon_NgayKham
            // 
            this.dateTimeHoaDon_NgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHoaDon_NgayKham.Location = new System.Drawing.Point(386, 28);
            this.dateTimeHoaDon_NgayKham.MinDate = new System.DateTime(2000, 1, 1, 12, 0, 0, 0);
            this.dateTimeHoaDon_NgayKham.Name = "dateTimeHoaDon_NgayKham";
            this.dateTimeHoaDon_NgayKham.Size = new System.Drawing.Size(166, 20);
            this.dateTimeHoaDon_NgayKham.TabIndex = 1;
            // 
            // textBoxHoaDon_TienThuoc
            // 
            this.textBoxHoaDon_TienThuoc.Location = new System.Drawing.Point(386, 59);
            this.textBoxHoaDon_TienThuoc.Name = "textBoxHoaDon_TienThuoc";
            this.textBoxHoaDon_TienThuoc.Size = new System.Drawing.Size(166, 20);
            this.textBoxHoaDon_TienThuoc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiền thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày khám";
            // 
            // btnHoaDon_Luu
            // 
            this.btnHoaDon_Luu.Location = new System.Drawing.Point(247, 129);
            this.btnHoaDon_Luu.Name = "btnHoaDon_Luu";
            this.btnHoaDon_Luu.Size = new System.Drawing.Size(75, 23);
            this.btnHoaDon_Luu.TabIndex = 38;
            this.btnHoaDon_Luu.Text = "LƯU";
            this.btnHoaDon_Luu.UseVisualStyleBackColor = true;
            // 
            // textBoxHoaDon_TienKham
            // 
            this.textBoxHoaDon_TienKham.Location = new System.Drawing.Point(121, 57);
            this.textBoxHoaDon_TienKham.Name = "textBoxHoaDon_TienKham";
            this.textBoxHoaDon_TienKham.Size = new System.Drawing.Size(166, 20);
            this.textBoxHoaDon_TienKham.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền khám";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbHoaDon_HoTen);
            this.groupBox1.Controls.Add(this.dateTimeHoaDon_NgayKham);
            this.groupBox1.Controls.Add(this.textBoxHoaDon_TienKham);
            this.groupBox1.Controls.Add(this.textBoxHoaDon_TienThuoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 91);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbbHoaDon_HoTen
            // 
            this.cbbHoaDon_HoTen.FormattingEnabled = true;
            this.cbbHoaDon_HoTen.Location = new System.Drawing.Point(121, 27);
            this.cbbHoaDon_HoTen.Name = "cbbHoaDon_HoTen";
            this.cbbHoaDon_HoTen.Size = new System.Drawing.Size(166, 21);
            this.cbbHoaDon_HoTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // formHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 171);
            this.Controls.Add(this.btnHoaDon_Thoat);
            this.Controls.Add(this.btnHoaDon_Luu);
            this.Controls.Add(this.groupBox1);
            this.Name = "formHoaDon";
            this.Text = "Hóa đơn thanh toán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHoaDon_Thoat;
        private System.Windows.Forms.DateTimePicker dateTimeHoaDon_NgayKham;
        private System.Windows.Forms.TextBox textBoxHoaDon_TienThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHoaDon_Luu;
        private System.Windows.Forms.TextBox textBoxHoaDon_TienKham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbHoaDon_HoTen;
        private System.Windows.Forms.Label label2;
    }
}