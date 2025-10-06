using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bai1
{
    public partial class Bai4: Form
    {
        Dictionary<string, (int Gia, int[] Phong)> movies = new Dictionary<string, (int Gia, int[] Phong)>()
    {
        { "Đào, phở và piano", (45000, new int[]{1,2,3}) },
        { "Mai", (100000, new int[]{2,3}) },
        { "Gặp lại chị bầu", (70000, new int[]{1}) },
        { "Tarot", (90000, new int[]{3}) }
    };

        // Hệ số giá vé theo ghế
        Dictionary<string, double> seatRate = new Dictionary<string, double>()
        {
            { "A1", 0.25 }, { "A5", 0.25 }, { "C1", 0.25 }, { "C5", 0.25 },
            { "A2", 1 }, { "A3", 1 }, { "A4", 1 }, { "C2", 1 }, { "C3", 1 }, { "C4", 1 },
            { "B2", 2 }, { "B3", 2 }, { "B4", 2 }
        };

        // Ghế đã bán
        HashSet<string> bookedSeats = new HashSet<string>();
        List<string> bookedTickets = new List<string>();
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            cboMovie.DataSource = movies.Keys.ToList();
            if (cboMovie.Items.Count > 0)
            {
                cboMovie.SelectedIndex = 0; // ép chọn phim đầu tiên
                LoadRoomsForMovie(cboMovie.SelectedItem.ToString());
            }
            cboMovie.SelectedIndexChanged += cboMovie_SelectedIndexChanged;
            clbVeVot.Items.AddRange(new object[] { "A1", "A5", "C1", "C5" });
            clbVeThuong.Items.AddRange(new object[] { "A2", "A3", "A4", "C2", "C3", "C4" });
            clbVeVIP.Items.AddRange(new object[] { "B2", "B3", "B4" });
        }
        private void LoadRoomsForMovie(string movie)
        {
            cboRoom.Items.Clear();
            if (!movies.ContainsKey(movie)) return;

            foreach (int room in movies[movie].Phong)
            {
                cboRoom.Items.Add("Phòng " + room);
            }

            if (cboRoom.Items.Count > 0)
                cboRoom.SelectedIndex = 0;
        }
        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMovie.SelectedItem != null)
                LoadRoomsForMovie(cboMovie.SelectedItem.ToString());

        }
        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMovie = cboMovie.SelectedItem?.ToString();
            string selectedRoom = cboRoom.SelectedItem?.ToString();

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập họ tên khách hàng!");
                return;
            }

            if (cboMovie.SelectedItem == null || cboRoom.SelectedItem == null)
            {
                MessageBox.Show("Chọn phim và phòng chiếu!");
                return;
            }

            string movie = cboMovie.SelectedItem.ToString();
            int basePrice = movies[movie].Gia;
            string roomText = cboRoom.SelectedItem.ToString();
            int room = int.Parse(roomText.Replace("Phòng ", ""));

            var selectedSeats = new List<string>();
            selectedSeats.AddRange(clbVeVot.CheckedItems.Cast<string>());
            selectedSeats.AddRange(clbVeThuong.CheckedItems.Cast<string>());
            selectedSeats.AddRange(clbVeVIP.CheckedItems.Cast<string>());

            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất 1 ghế!");
                return;
            }

            // Kiểm tra ghế đã bán
            foreach (var seat in selectedSeats)
            {
                string key = $"{room}-{seat}";
                if (bookedSeats.Contains(key))
                {
                    MessageBox.Show($"Ghế {seat} (phòng {room}) đã được bán!");
                    return;
                }
            }

            // Tính tiền
            double total = 0;
            foreach (var seat in selectedSeats)
            {
                if (seatRate.ContainsKey(seat))
                    total += basePrice * seatRate[seat];
                else
                    total += basePrice; 
            }

            // Đánh dấu ghế đã bán
            foreach (var seat in selectedSeats)
            {
                string key = $"{room}-{seat}";
                bookedSeats.Add(key);
            }
            string ticketInfo = $"Khách: {name} \r\n Phim: {movie} \r\n Phòng: {room} \r\n Ghế: {string.Join(",", selectedSeats)} \r\n Thành tiền: {total}đ";
            bookedTickets.Add(ticketInfo);

            // Hiện thông báo
            MessageBox.Show("Đặt vé thành công!");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (bookedTickets.Count == 0)
            {
                MessageBox.Show("Chưa có vé nào được đặt!");
                return;
            }

            string allTickets = string.Join(
        "\r\n----------------------\r\n",
        bookedTickets
    );
            MessageBox.Show(allTickets, "Danh sách vé đã đặt");
        }

        private void lbVeThuong_Click(object sender, EventArgs e)
        {

        }
    }
    }

