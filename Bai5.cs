using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai1
{
    public partial class Bai5: Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txtA.Text, out a) || !int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtKetQua.Clear();
            string selected = comboBoxChoice.Text.ToString();
            if (selected == "Bảng cửu chương")
            {
                int x = b - a;
                if (x < 0)
                {
                    MessageBox.Show("Không hợp lệ! (B phải lớn hơn A)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtKetQua.AppendText("Bảng cửu chương " + x + "\r\n");
                    for (int i = 1; i <= 10; i++)
                    {
                        txtKetQua.AppendText(x + " x " + i + " = " + (x * i) + "\r\n");
                    }
                    txtKetQua.AppendText("\r\n");
                    txtKetQua.SelectionStart = 0;
                    txtKetQua.ScrollToCaret();
                }
            }
            else if (selected == "Tính toán giá trị")
            {
                int x = a - b;
                if (x < 0)
                {
                    MessageBox.Show("Không hợp lệ! (A phải lớn hơn B)","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    long t = 1;
                    double s = 0;
                    for(int i = 1; i <= x; i++)
                    {
                        t *= i;
                    }
                    txtKetQua.Text = "(A-B)! = " + t + "\r\n";
                    ulong tong = 0;
                    ulong luythua = 1;

                    for (int i = 1; i <= b; i++)
                    {
                        luythua = luythua * (ulong)a;       
                        tong += luythua;    
                    }
                    txtKetQua.AppendText("S = " + tong.ToString());
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn chức năng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            comboBoxChoice.SelectedIndex = -1;
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }
    }
}
