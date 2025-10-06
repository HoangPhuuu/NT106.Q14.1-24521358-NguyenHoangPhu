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
    public partial class Bai3_1: Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
            
        }

        private string DocBaChuSo(int so)
        {
            string[] donVi = { "", "một", "hai", "ba", "bốn", "năm",
                       "sáu", "bảy", "tám", "chín" };

            int tram = so / 100;
            int chuc = (so / 10) % 10;
            int dv = so % 10;

            string kq = "";

            if (tram > 0)
            {
                kq += donVi[tram] + " trăm";
            }

            if (chuc > 1)
            {
                kq += " " + donVi[chuc] + " mươi";
                if (dv == 1) kq += " mốt";
                else if (dv == 5) kq += " lăm";
                else if (dv > 0) kq += " " + donVi[dv];
            }
            else if (chuc == 1)
            {
                kq += " mười";
                if (dv == 5) kq += " lăm";
                else if (dv > 0) kq += " " + donVi[dv];
            }
            else 
            {
                if (tram > 0 && dv > 0)
                {
                    kq += " lẻ " + donVi[dv];
                }
                else if (tram == 0 && dv > 0)
                {
                    kq += donVi[dv];
                }
            }

            return kq.Trim();
        }


        private string DocSo(long so)
        {
            if (so == 0) return "Không";

            string[] hang = { "", "ngàn", "triệu", "tỷ" };
            string kq = "";

            int i = 0;
            while (so > 0)
            {
                int block = (int)(so % 1000);
                if (block > 0)
                {
                    string chu = DocBaChuSo(block);
                    if (hang[i] != "") chu += " " + hang[i];
                    kq = chu + " " + kq;
                }
                so /= 1000;
                i++;
            }

            return kq.Trim();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string input = txtNhap.Text.Trim();
            if (input.Length > 12)
            {
                MessageBox.Show("Chỉ được nhập tối đa 12 chữ số!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
                return;
            }
            if (long.TryParse(input, out long n))
            {
                string ketQua = DocSo(n);

                if (!string.IsNullOrEmpty(ketQua))
                {
                    ketQua = char.ToUpper(ketQua[0]) + ketQua.Substring(1);
                }
                txtKetQua.Text = ketQua;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!",
                        "Lỗi nhập liệu",
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

