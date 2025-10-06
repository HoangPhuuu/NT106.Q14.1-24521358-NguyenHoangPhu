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
    public partial class Bai6: Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            int ngay, thang;

            if (!int.TryParse(txtNgay.Text, out ngay) || !int.TryParse(txtThang.Text, out thang))
            {
                MessageBox.Show("Vui lòng nhập ngày và tháng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isLeap = false;
            if (int.TryParse(txtNam.Text.Trim(), out int nam))
            {
                isLeap = (nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0);
            }
            // xác định số ngày tối đa của tháng
            int maxDay;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    maxDay = 31; break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDay = 30; break;
                case 2:
                    maxDay = isLeap ? 29 : 28; break;
                default:
                    MessageBox.Show("Tháng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            if (ngay < 1 || ngay > maxDay)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtKetQua.Text = "Ngày tháng năm sinh của bạn là: " + txtNgay.Text + "/" + txtThang.Text + "/" + txtNam.Text + "\r\n";

            string cung = "";

            switch (thang)
            {
                case 1:
                    cung = (ngay >= 21) ? "Bảo Bình" : "Ma Kết";
                    break;
                case 2:
                    if (ngay <= 19) cung = "Bảo Bình";
                    else if (ngay <= 29) cung = "Song Ngư"; 
                    else
                    {
                        MessageBox.Show("Ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 3:
                    cung = (ngay >= 21) ? "Bạch Dương" : "Song Ngư";
                    break;
                case 4:
                    if (ngay <= 20) cung = "Bạch Dương";
                    else if (ngay <= 30) cung = "Kim Ngưu";
                    else
                    {
                        MessageBox.Show("Ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 5:
                    cung = (ngay >= 22) ? "Song Tử" : "Kim Ngưu";
                    break;
                case 6:
                    cung = (ngay >= 22) ? "Cự Giải" : "Song Tử";
                    break;
                case 7:
                    cung = (ngay >= 23) ? "Sư Tử" : "Cự Giải";
                    break;
                case 8:
                    cung = (ngay >= 23) ? "Xử Nữ" : "Sư Tử";
                    break;
                case 9:
                    cung = (ngay >= 24) ? "Thiên Bình" : "Xử Nữ";
                    break;
                case 10:
                    cung = (ngay >= 24) ? "Thần Nông" : "Thiên Bình";
                    break;
                case 11:
                    cung = (ngay >= 23) ? "Nhân Mã" : "Thần Nông";
                    break;
                case 12:
                    cung = (ngay >= 22) ? "Ma Kết" : "Nhân Mã";
                    break;
                default:
                    MessageBox.Show("Tháng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            txtKetQua.AppendText("Cung hoàng đạo của bạn là: " + cung);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNgay.Clear();
            txtThang.Clear();
            txtNam.Clear();
            txtKetQua.Clear();
            txtNgay.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
