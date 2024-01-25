using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FormDanhSachHopDong : Form
    {
        private List<HopDong> dshopdong = new List<HopDong>
        {
            new HopDong("Nguyễn Văn A", "Nguyễn Văn B", new DateTime(2021, 09, 12), new DateTime(2022, 04, 15), "theo ca"),
            new HopDong("Nguyễn Văn E", "Nguyễn Văn C", new DateTime(2022, 08, 11), new DateTime(2023, 05, 11), "theo ca"),
            new HopDong("Nguyễn Văn H", "Nguyễn Văn E", DateTime.Now, DateTime.Now.AddMonths(6), "theo giờ")
        };

        public FormDanhSachHopDong()
        {
            InitializeComponent();
            LoadDanhSachHopDong();
        }

        void LoadDanhSachHopDong()
        {
            dataGridViewHopDong.DataSource = dshopdong;
            dataGridViewHopDong.Columns[0].HeaderText = "Họ và tên người thuê";
            dataGridViewHopDong.Columns[1].HeaderText = "Họ và tên người giúp việc";
            dataGridViewHopDong.Columns[2].HeaderText = "Ngày bắt đầu";
            dataGridViewHopDong.Columns[3].HeaderText = "Ngày kết thúc";
            dataGridViewHopDong.Columns[4].HeaderText = "Loại hợp đồng";
            dataGridViewHopDong.Columns[5].Visible = false;
            dataGridViewHopDong.Columns[6].Visible = false;
        }

        public void ThemHopDongVaoDanhSach(HopDong newHopDong)
        {
            dshopdong.Add(newHopDong);
        }

        private void buttonTaiHD_Click(object sender, EventArgs e)
        {
            if (dataGridViewHopDong.SelectedRows.Count > 0)
            {
                HopDong hopDongDaChon = dataGridViewHopDong.SelectedRows[0].DataBoundItem as HopDong;
                hopDongDaChon.TaiHopDong();
                MessageBox.Show("Tái hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng để tái hợp đồng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHuyHD_Click(object sender, EventArgs e)
        {
            if (dataGridViewHopDong.SelectedRows.Count > 0)
            {
                HopDong hopDongDaChon = dataGridViewHopDong.SelectedRows[0].DataBoundItem as HopDong;
                
                DialogResult result = MessageBox.Show("Bạn có chăc muôn hủy hợp đồng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    hopDongDaChon.HuyHopDong(dshopdong, hopDongDaChon);
                    dataGridViewHopDong.DataSource = null;
                    dataGridViewHopDong.DataSource = dshopdong;
                    MessageBox.Show("Hủy hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng để hủy hợp đồng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
