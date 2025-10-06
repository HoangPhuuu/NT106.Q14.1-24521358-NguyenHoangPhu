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
    public partial class Bai8: Form
    {
        Random rnd = new Random();
        public Bai8()
        {
            InitializeComponent();
        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            string[] defaultFoods = { "Bún riêu", "Bún thịt nướng", "Cơm tấm sườn trứng", "Phở", "Gỏi cuốn" };
            listMonAn.Items.AddRange(defaultFoods);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (listMonAn.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn rỗng!", "Thông báo");
                return;
            }
            if (listMonAn.Items.Count == 1)
            {
                MessageBox.Show("Phải có ít nhất 2 món ăn!", "Thông báo");
                return;
            }

            int index = rnd.Next(listMonAn.Items.Count);
            string monAn = listMonAn.Items[index].ToString();
            txtKetQua.Text = monAn;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listMonAn.SelectedIndex >= 0)
            {
                listMonAn.Items.RemoveAt(listMonAn.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Hãy chọn món ăn để xóa!", "Thông báo");
            }
            txtKetQua.Clear();
            txtMonAn.Clear();
            txtMonAn.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mon = txtMonAn.Text.Trim();
            if (mon == "")
            {
                MessageBox.Show("Vui lòng nhập món ăn!", "Thông báo");
                return;
            }

            listMonAn.Items.Add(mon);
            txtMonAn.Clear();
            txtMonAn.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
