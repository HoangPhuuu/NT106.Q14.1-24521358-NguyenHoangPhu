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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
        }
        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.ShowDialog();
        }
        private void btnBai3_1_Click(object sender, EventArgs e)
        {
            Bai3_1 b3_1 = new Bai3_1();
            b3_1.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai4 b4 = new Bai4();
            b4.ShowDialog();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Bai5 b5 = new Bai5();
            b5.ShowDialog();
        }
        private void btnBai6_Click(object sender, EventArgs e)
        {
            Bai6 b6 = new Bai6();
            b6.ShowDialog();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            Bai7 b7 = new Bai7();
            b7.ShowDialog();
        }

        private void btnBai8_Click(object sender, EventArgs e)
        {
            Bai8 b8 = new Bai8();
            b8.ShowDialog();
        }
    }
}
