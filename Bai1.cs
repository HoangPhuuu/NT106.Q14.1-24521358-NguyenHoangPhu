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
    public partial class Bai1: Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int so1, so2, tong;

            if (!int.TryParse(So1.Text.Trim(), out so1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!","Lỗi",   
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(So2.Text.Trim(), out so2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            tong = so1 + so2;

            KetQua.Text = tong.ToString();
        }

        private void So1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            So1.Clear();
            So2.Clear();
            KetQua.Clear();
            So1.Focus();
        }
    }
}
