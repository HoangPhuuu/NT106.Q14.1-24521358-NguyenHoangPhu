namespace bai1
{
    partial class Bai3_1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lbNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Silver;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(636, 290);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(636, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.Silver;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(636, 127);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(80, 40);
            this.btnDoc.TabIndex = 11;
            this.btnDoc.Text = "Đọc";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(78, 291);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(85, 25);
            this.lbKetQua.TabIndex = 10;
            this.lbKetQua.Text = "Kết Quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(196, 280);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(350, 80);
            this.txtKetQua.TabIndex = 9;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(343, 138);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNhap.Size = new System.Drawing.Size(212, 27);
            this.txtNhap.TabIndex = 8;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhap.Location = new System.Drawing.Point(12, 140);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(297, 25);
            this.lbNhap.TabIndex = 7;
            this.lbNhap.Text = "Nhập vào số nguyên tối đa 12 số";
            // 
            // Bai3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbNhap);
            this.Name = "Bai3_1";
            this.Text = "Đọc số (nâng cao)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lbNhap;
    }
}