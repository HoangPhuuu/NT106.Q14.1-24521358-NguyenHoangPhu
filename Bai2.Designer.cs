namespace bai1
{
    partial class Bai2
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
            this.content = new System.Windows.Forms.Label();
            this.lbSo1 = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbSo3 = new System.Windows.Forms.Label();
            this.So1 = new System.Windows.Forms.TextBox();
            this.So2 = new System.Windows.Forms.TextBox();
            this.So3 = new System.Windows.Forms.TextBox();
            this.tim = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.BackColor = System.Drawing.SystemColors.Control;
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ForeColor = System.Drawing.Color.Red;
            this.content.Location = new System.Drawing.Point(300, 40);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(186, 32);
            this.content.TabIndex = 0;
            this.content.Text = "TÌM MIN MAX";
            // 
            // lbSo1
            // 
            this.lbSo1.AutoSize = true;
            this.lbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo1.Location = new System.Drawing.Point(13, 110);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(112, 25);
            this.lbSo1.TabIndex = 1;
            this.lbSo1.Text = "Số thứ nhất";
            this.lbSo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSo2
            // 
            this.lbSo2.AutoSize = true;
            this.lbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo2.Location = new System.Drawing.Point(283, 110);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(100, 25);
            this.lbSo2.TabIndex = 2;
            this.lbSo2.Text = "Số thứ hai";
            // 
            // lbSo3
            // 
            this.lbSo3.AutoSize = true;
            this.lbSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo3.Location = new System.Drawing.Point(533, 110);
            this.lbSo3.Name = "lbSo3";
            this.lbSo3.Size = new System.Drawing.Size(96, 25);
            this.lbSo3.TabIndex = 3;
            this.lbSo3.Text = "Số thứ ba";
            // 
            // So1
            // 
            this.So1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So1.Location = new System.Drawing.Point(154, 110);
            this.So1.Name = "So1";
            this.So1.Size = new System.Drawing.Size(100, 30);
            this.So1.TabIndex = 4;
            // 
            // So2
            // 
            this.So2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So2.Location = new System.Drawing.Point(404, 110);
            this.So2.Name = "So2";
            this.So2.Size = new System.Drawing.Size(100, 30);
            this.So2.TabIndex = 5;
            // 
            // So3
            // 
            this.So3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So3.Location = new System.Drawing.Point(664, 110);
            this.So3.Name = "So3";
            this.So3.Size = new System.Drawing.Size(100, 30);
            this.So3.TabIndex = 6;
            // 
            // tim
            // 
            this.tim.BackColor = System.Drawing.Color.Silver;
            this.tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim.Location = new System.Drawing.Point(99, 215);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(80, 40);
            this.tim.TabIndex = 7;
            this.tim.Text = "Tìm";
            this.tim.UseVisualStyleBackColor = false;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(80, 325);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(111, 25);
            this.max.TabIndex = 8;
            this.max.Text = "Số lớn nhất";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(430, 325);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(118, 25);
            this.min.TabIndex = 9;
            this.min.Text = "Số nhỏ nhất";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMax.Location = new System.Drawing.Point(214, 325);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(100, 30);
            this.textBoxMax.TabIndex = 10;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMin.Location = new System.Drawing.Point(564, 322);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(100, 30);
            this.textBoxMin.TabIndex = 11;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(349, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Silver;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(599, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.So3);
            this.Controls.Add(this.So2);
            this.Controls.Add(this.So1);
            this.Controls.Add(this.lbSo3);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Controls.Add(this.content);
            this.Name = "Bai2";
            this.Text = "Số lớn nhất,nhỏ nhất";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label content;
        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbSo3;
        private System.Windows.Forms.TextBox So1;
        private System.Windows.Forms.TextBox So2;
        private System.Windows.Forms.TextBox So3;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}