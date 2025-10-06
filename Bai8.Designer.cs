namespace bai1
{
    partial class Bai8
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
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtMonAn = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.listMonAn = new System.Windows.Forms.ListBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhap.Location = new System.Drawing.Point(51, 61);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(129, 25);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập món ăn";
            // 
            // txtMonAn
            // 
            this.txtMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonAn.Location = new System.Drawing.Point(212, 59);
            this.txtMonAn.Name = "txtMonAn";
            this.txtMonAn.Size = new System.Drawing.Size(175, 30);
            this.txtMonAn.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(268, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 36);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listMonAn
            // 
            this.listMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMonAn.FormattingEnabled = true;
            this.listMonAn.ItemHeight = 25;
            this.listMonAn.Location = new System.Drawing.Point(460, 34);
            this.listMonAn.Name = "listMonAn";
            this.listMonAn.Size = new System.Drawing.Size(271, 179);
            this.listMonAn.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightCoral;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(56, 248);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(174, 40);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm món ăn";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(307, 248);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(174, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa món ăn";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(529, 248);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(174, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(285, 337);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(184, 25);
            this.lbKetQua.TabIndex = 7;
            this.lbKetQua.Text = "Món ăn hôm nay là:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(236, 377);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(294, 34);
            this.txtKetQua.TabIndex = 8;
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.listMonAn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMonAn);
            this.Controls.Add(this.lbNhap);
            this.Name = "Bai8";
            this.Text = "Ăn gì cũng được";
            this.Load += new System.EventHandler(this.Bai8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtMonAn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox listMonAn;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}