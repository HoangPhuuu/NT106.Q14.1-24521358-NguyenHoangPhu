namespace bai1
{
    partial class Bai4
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
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.clbVeVot = new System.Windows.Forms.CheckedListBox();
            this.clbVeThuong = new System.Windows.Forms.CheckedListBox();
            this.clbVeVIP = new System.Windows.Forms.CheckedListBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMovie = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbVeVot = new System.Windows.Forms.Label();
            this.lbVeThuong = new System.Windows.Forms.Label();
            this.lbVeVIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboRoom
            // 
            this.cboRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(225, 213);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(226, 33);
            this.cboRoom.TabIndex = 1;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // cboMovie
            // 
            this.cboMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Location = new System.Drawing.Point(225, 133);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(226, 33);
            this.cboMovie.TabIndex = 2;
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.LightYellow;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(108, 333);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(131, 59);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Đặt vé";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(225, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 30);
            this.txtName.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightYellow;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(289, 333);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(162, 59);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Kiểm tra vé";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // clbVeVot
            // 
            this.clbVeVot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbVeVot.FormattingEnabled = true;
            this.clbVeVot.Location = new System.Drawing.Point(777, 12);
            this.clbVeVot.Name = "clbVeVot";
            this.clbVeVot.Size = new System.Drawing.Size(120, 104);
            this.clbVeVot.TabIndex = 6;
            // 
            // clbVeThuong
            // 
            this.clbVeThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbVeThuong.FormattingEnabled = true;
            this.clbVeThuong.Location = new System.Drawing.Point(777, 150);
            this.clbVeThuong.Name = "clbVeThuong";
            this.clbVeThuong.Size = new System.Drawing.Size(120, 154);
            this.clbVeThuong.TabIndex = 7;
            // 
            // clbVeVIP
            // 
            this.clbVeVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbVeVIP.FormattingEnabled = true;
            this.clbVeVIP.Location = new System.Drawing.Point(777, 342);
            this.clbVeVIP.Name = "clbVeVIP";
            this.clbVeVIP.Size = new System.Drawing.Size(120, 104);
            this.clbVeVIP.TabIndex = 8;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(25, 53);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(118, 25);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Nhập họ tên";
            // 
            // lbMovie
            // 
            this.lbMovie.AutoSize = true;
            this.lbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovie.Location = new System.Drawing.Point(25, 133);
            this.lbMovie.Name = "lbMovie";
            this.lbMovie.Size = new System.Drawing.Size(107, 25);
            this.lbMovie.TabIndex = 10;
            this.lbMovie.Text = "Chọn phim";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(25, 213);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(172, 25);
            this.lbRoom.TabIndex = 11;
            this.lbRoom.Text = "Chọn phòng chiếu";
            // 
            // lbVeVot
            // 
            this.lbVeVot.AutoSize = true;
            this.lbVeVot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVeVot.Location = new System.Drawing.Point(672, 58);
            this.lbVeVot.Name = "lbVeVot";
            this.lbVeVot.Size = new System.Drawing.Size(68, 25);
            this.lbVeVot.TabIndex = 12;
            this.lbVeVot.Text = "Vé vớt";
            // 
            // lbVeThuong
            // 
            this.lbVeThuong.AutoSize = true;
            this.lbVeThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVeThuong.Location = new System.Drawing.Point(638, 213);
            this.lbVeThuong.Name = "lbVeThuong";
            this.lbVeThuong.Size = new System.Drawing.Size(102, 25);
            this.lbVeThuong.TabIndex = 13;
            this.lbVeThuong.Text = "Vé thường";
            this.lbVeThuong.Click += new System.EventHandler(this.lbVeThuong_Click);
            // 
            // lbVeVIP
            // 
            this.lbVeVIP.AutoSize = true;
            this.lbVeVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVeVIP.Location = new System.Drawing.Point(666, 384);
            this.lbVeVIP.Name = "lbVeVIP";
            this.lbVeVIP.Size = new System.Drawing.Size(74, 25);
            this.lbVeVIP.TabIndex = 14;
            this.lbVeVIP.Text = "Vé VIP";
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 485);
            this.Controls.Add(this.lbVeVIP);
            this.Controls.Add(this.lbVeThuong);
            this.Controls.Add(this.lbVeVot);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.lbMovie);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.clbVeVIP);
            this.Controls.Add(this.clbVeThuong);
            this.Controls.Add(this.clbVeVot);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.cboRoom);
            this.Name = "Bai4";
            this.Text = "Quản Lý Phòng Vé";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.CheckedListBox clbVeVot;
        private System.Windows.Forms.CheckedListBox clbVeThuong;
        private System.Windows.Forms.CheckedListBox clbVeVIP;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMovie;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbVeVot;
        private System.Windows.Forms.Label lbVeThuong;
        private System.Windows.Forms.Label lbVeVIP;
    }
}