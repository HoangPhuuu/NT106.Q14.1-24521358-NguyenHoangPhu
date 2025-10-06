namespace bai1
{
    partial class Bai6
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
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.grKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.grKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.Pink;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(145, 151);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(202, 50);
            this.btnXuat.TabIndex = 0;
            this.btnXuat.Text = "Xuất thông tin";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Pink;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(410, 151);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 50);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Pink;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(593, 151);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 50);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(150, 60);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(100, 30);
            this.txtNgay.TabIndex = 3;
            this.txtNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(430, 60);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 30);
            this.txtThang.TabIndex = 4;
            this.txtThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(720, 60);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 30);
            this.txtNam.TabIndex = 5;
            this.txtNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(20, 60);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(107, 25);
            this.lbNgay.TabIndex = 6;
            this.lbNgay.Text = "Nhập ngày";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(300, 60);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(113, 25);
            this.lbThang.TabIndex = 7;
            this.lbThang.Text = "Nhập tháng";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNam.Location = new System.Drawing.Point(590, 60);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(102, 25);
            this.lbNam.TabIndex = 8;
            this.lbNam.Text = "Nhập năm";
            // 
            // grKetQua
            // 
            this.grKetQua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grKetQua.Controls.Add(this.txtKetQua);
            this.grKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKetQua.Location = new System.Drawing.Point(150, 240);
            this.grKetQua.Name = "grKetQua";
            this.grKetQua.Size = new System.Drawing.Size(565, 180);
            this.grKetQua.TabIndex = 9;
            this.grKetQua.TabStop = false;
            this.grKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.Control;
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(12, 50);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(540, 107);
            this.txtKetQua.TabIndex = 0;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.grKetQua);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXuat);
            this.Name = "Bai6";
            this.Text = "Kiểm tra cung hoàng đạo";
            this.grKetQua.ResumeLayout(false);
            this.grKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.GroupBox grKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}