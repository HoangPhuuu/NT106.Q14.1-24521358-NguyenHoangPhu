using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Bai3: Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        

        private void btnDoc_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNhap.Text, out n))
            {
                string chu;
                switch (n)
                {
                    case 0: chu = "Không"; break;
                    case 1: chu = "Một"; break;
                    case 2: chu = "Hai"; break;
                    case 3: chu = "Ba"; break;
                    case 4: chu = "Bốn"; break;
                    case 5: chu = "Năm"; break;
                    case 6: chu = "Sáu"; break;
                    case 7: chu = "Bảy"; break;
                    case 8: chu = "Tám"; break;
                    case 9: chu = "Chín"; break;
                    default:
                        MessageBox.Show("Vui lòng nhập số từ 0 đến 9!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                }
                txtKetQua.Text = chu;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKetQua.Clear();
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
