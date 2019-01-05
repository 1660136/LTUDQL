namespace DALTUDQL_1660007_1660010_1660136
{
    partial class formBCDT
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBCDT = new System.Windows.Forms.DataGridView();
            this.btnBCDT_Thoat = new System.Windows.Forms.Button();
            this.cbbBCDT_Thang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewBCDT);
            this.groupBox4.Location = new System.Drawing.Point(10, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(645, 208);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Báo cáo doanh thu theo ngày";
            // 
            // dataGridViewBCDT
            // 
            this.dataGridViewBCDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBCDT.Location = new System.Drawing.Point(0, 19);
            this.dataGridViewBCDT.Name = "dataGridViewBCDT";
            this.dataGridViewBCDT.Size = new System.Drawing.Size(632, 182);
            this.dataGridViewBCDT.TabIndex = 0;
            // 
            // btnBCDT_Thoat
            // 
            this.btnBCDT_Thoat.Location = new System.Drawing.Point(577, 263);
            this.btnBCDT_Thoat.Name = "btnBCDT_Thoat";
            this.btnBCDT_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btnBCDT_Thoat.TabIndex = 29;
            this.btnBCDT_Thoat.Text = "THOÁT";
            this.btnBCDT_Thoat.UseVisualStyleBackColor = true;
            // 
            // cbbBCDT_Thang
            // 
            this.cbbBCDT_Thang.FormattingEnabled = true;
            this.cbbBCDT_Thang.Location = new System.Drawing.Point(56, 14);
            this.cbbBCDT_Thang.Name = "cbbBCDT_Thang";
            this.cbbBCDT_Thang.Size = new System.Drawing.Size(71, 21);
            this.cbbBCDT_Thang.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tháng";
            // 
            // formBCDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 301);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnBCDT_Thoat);
            this.Controls.Add(this.cbbBCDT_Thang);
            this.Controls.Add(this.label1);
            this.Name = "formBCDT";
            this.Text = "Báo cáo doanh thu";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewBCDT;
        private System.Windows.Forms.Button btnBCDT_Thoat;
        private System.Windows.Forms.ComboBox cbbBCDT_Thang;
        private System.Windows.Forms.Label label1;
    }
}