namespace bai1
{
    partial class Bai5
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
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.grKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(110, 30);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(94, 28);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Nhập A";
            // 
            // lbB
            // 
            this.lbB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(440, 30);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(88, 28);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "Nhập B";
            // 
            // txtA
            // 
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(220, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(110, 38);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(550, 30);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(110, 38);
            this.txtB.TabIndex = 3;
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.comboBoxChoice.Location = new System.Drawing.Point(320, 90);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(210, 36);
            this.comboBoxChoice.TabIndex = 4;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.LightCoral;
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(145, 160);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(181, 40);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "Tính các giá trị";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(400, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(570, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grKetQua
            // 
            this.grKetQua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grKetQua.Controls.Add(this.txtKetQua);
            this.grKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKetQua.Location = new System.Drawing.Point(121, 238);
            this.grKetQua.Name = "grKetQua";
            this.grKetQua.Size = new System.Drawing.Size(600, 240);
            this.grKetQua.TabIndex = 8;
            this.grKetQua.TabStop = false;
            this.grKetQua.Text = "KẾT QUẢ";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(24, 33);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(549, 190);
            this.txtKetQua.TabIndex = 10;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(913, 507);
            this.Controls.Add(this.grKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.comboBoxChoice);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Name = "Bai5";
            this.Text = "Tính kết quả";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.grKetQua.ResumeLayout(false);
            this.grKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.ComboBox comboBoxChoice;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}