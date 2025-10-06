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
    public partial class Bai2: Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Bai2_Load(object sender, EventArgs e)
        {
           
        }

        private void tim_Click(object sender, EventArgs e)
        {
            int so1, so2,so3;

            if (!int.TryParse(So1.Text.Trim(), out so1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(So2.Text.Trim(), out so2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(So3.Text.Trim(), out so3))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(So1.Text) ||
                string.IsNullOrWhiteSpace(So2.Text) ||
                string.IsNullOrWhiteSpace(So3.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ 3 số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                int max = so1;
                int min = so1;

            if (so2 > max) max = so2;
            if (so3 > max) max = so3;

            if (so2 < min) min = so2;
            if (so3 < min) min = so3;
            textBoxMax.Text = max.ToString();
            textBoxMin.Text = min.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            So1.Clear();
            So2.Clear();
            So3.Clear();
            textBoxMax.Clear();
            textBoxMin.Clear();
            So1.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
