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
    public partial class Bai7: Form
    {
        public Bai7()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = ""; // Xóa kết quả cũ
            string input = txtInput.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(input) || !input.Contains(","))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] parts = input.Split(',');
            string name = parts[0].Trim();
            double[] scores = new double[parts.Length - 1];

            bool valid = true;
            for (int i = 1; i < parts.Length; i++)
            {
                if (double.TryParse(parts[i].Trim(), out double s))
                    scores[i - 1] = s;
                else
                {
                    valid = false;
                    break;
                }
            }

            if (!valid)
            {
                MessageBox.Show("Sai format điểm! Hãy nhập số hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xuất kết quả
            txtKetQua.Text += "Họ và tên: " + name + "\r\n";

            for (int i = 0; i < scores.Length; i++)
                txtKetQua.Text += "Môn " + (i + 1) + ": " + scores[i] + "\r\n";

            // Điểm trung bình
            double avg = scores.Average();
            txtKetQua.Text += "\nĐiểm trung bình: " + avg.ToString("0.00") + "\r\n";

            // Điểm max/min
            double max = scores.Max();
            double min = scores.Min();
            int monMax = Array.IndexOf(scores, max) + 1;
            int monMin = Array.IndexOf(scores, min) + 1;
            txtKetQua.Text += "Môn điểm cao nhất: Môn " + monMax + " = " + max + "\r\n";
            txtKetQua.Text += "Môn điểm thấp nhất: Môn " + monMin + " = " + min + "\r\n";

            // Đếm đậu/rớt
            int pass = scores.Count(s => s >= 5);
            int fail = scores.Length - pass;
            txtKetQua.Text += "Số môn đậu: " + pass + "\r\n" + "Số môn rớt: " + fail + "\r\n";

            // Xếp loại
            string xepLoai = "Kém";
            if (avg >= 8 && scores.All(s => s >= 6.5))
                xepLoai = "Giỏi";
            else if (avg >= 6.5 && scores.All(s => s >= 5))
                xepLoai = "Khá";
            else if (avg >= 5 && scores.All(s => s >= 3.5))
                xepLoai = "Trung Bình";
            else if (avg >= 3.5 && scores.All(s => s >= 2))
                xepLoai = "Yếu";

            txtKetQua.Text += "Xếp loại: " + xepLoai;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtKetQua.Clear();
            txtInput.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
