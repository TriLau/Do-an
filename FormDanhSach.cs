using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DoAnCuoiKy
{
    public partial class FormDanhSach : Form
    {
        private List<NguoiThue> dsnguoithue = new List<NguoiThue>
        {
            new NguoiThue("Nguyen Van A", "0987654321", "123 Đường ABC, Quận XYZ", "Chăm người già, sạch sẽ, nấu ăn ngon", 3000000, "Thưởng tết, vé xe về tết, thưởng các ngày lễ", "vui vẻ, tốt bụng, hoạt ngôn", new List<LichSuThue>{ new LichSuThue( new DateTime(2021, 09, 27), "Nguyen Thi C"), new LichSuThue( new DateTime(2023, 02, 01), "Nguyen Thị A") } ),
            new NguoiThue("Nguyen Van B", "0987654232", "123 Đường ABC, Quận XYZ", "Chăm em bé, sạch sẽ, nấu ăn ngon", 3000000, "Thưởng tết, thưởng các ngày lễ", null, new List<LichSuThue>{ new LichSuThue( new DateTime(2021, 01, 25), "Nguyen Thi B"), new LichSuThue( new DateTime(2022, 02, 023), "Nguyen Thị D") } ),
            new NguoiThue("Nguyen Van C", "0987654354", "123 Đường ABC, Quận XYZ", "Chăm em bé, sạch sẽ, vui tính", 3000000, "Thưởng tết, vé xe về tết, thưởng các ngày lễ", "vui vẻ, tốt bụng", new List<LichSuThue>{ new LichSuThue( new DateTime(2022, 04, 24), "Nguyen Thi B"), new LichSuThue( new DateTime(2023, 02, 01), "Nguyen Thi E") } ),
            new NguoiThue("Nguyen Van D", "0987654334", "123 Đường ABC, Quận XYZ", "Chăm em bé, sạch sẽ, nấu ăn ngon", 3000000, "Thưởng tết, vé xe về tết, thưởng các ngày lễ", null, new List<LichSuThue>{ } ),
            new NguoiThue("Nguyen Van E", "0987654678", "123 Đường ABC, Quận XYZ", "Chăm em bé, chăm người bệnh, sạch sẽ, nấu ăn ngon", 3500000, "Thưởng tết, thưởng các ngày lễ", null, new List<LichSuThue>{ new LichSuThue( new DateTime(2023, 04, 23), "Nguyen Thi A"), new LichSuThue( new DateTime(2021, 09, 11), "nguyen Thi B"), new LichSuThue(new DateTime(2020, 03, 04), "Nguyen Thi C"), new LichSuThue( new DateTime(2020, 01, 01), "Nguyen Thi D") } ),
            new NguoiThue("Nguyen Van F", "0987654977", "123 Đường ABC, Quận XYZ", "Chăm em bé, sạch sẽ, nấu ăn ngon", 3000000, "Thưởng tết, vé xe về tết", null, new List<LichSuThue>{ new LichSuThue( new DateTime(2021, 11, 21), "Nguyen Thi F") } ),
            new NguoiThue("Nguyen Van G", "0987654567", "123 Đường ABC, Quận XYZ", "Chăm em bé, sạch sẽ, nấu ăn ngon, vui tính", 4000000, "Thưởng tết, vé xe về tết, thưởng các ngày lễ", null, new List<LichSuThue>{ new LichSuThue(new DateTime(2022, 02, 28), "Nguyen Thi E") } ),
        };

        private List<NguoiGiupViec> dsnguoigiupviec = new List<NguoiGiupViec>
        {
            new NguoiGiupViec("Nguyen Thi A", "0912345324", "Chăm người già, chăm em bé, dọn nhà lầu, nấu ăn", 2450000, "kỷ luật, nghiêm túc, dọn dẹp sạch sẽ", new List<LichSuLamViec> { new LichSuLamViec(new DateTime(2021, 01, 14), "abc, phố xyz"), new LichSuLamViec(new DateTime(2022, 03, 07), "asd, phố mnk") }),
            new NguoiGiupViec("Nguyen Thi B", "0912345345", "Chăm người già, chăm người bệnh, dọn nhà lầu, nấu ăn", 2500000, null, new List<LichSuLamViec> { new LichSuLamViec(new DateTime(2021, 01, 14), "abc, phố xyz"), new LichSuLamViec(new DateTime(2022, 03, 07), "asd, phố mnk") }),
            new NguoiGiupViec("Nguyen Thi C", "0912345657", "Chăm người già, chăm người bệnh, dọn nhà lầu, nấu ăn", 2500000, null, new List<LichSuLamViec> { new LichSuLamViec(new DateTime(2021, 01, 14), "abc, phố xyz"), new LichSuLamViec(new DateTime(2022, 03, 07), "asd, phố mnk") }),
            new NguoiGiupViec("Nguyen Thi D", "0912345786", "Chăm người già, dọn nhà lầu, nấu ăn", 2500000, null, new List<LichSuLamViec> { new LichSuLamViec(new DateTime(2021, 01, 14), "abc, phố xyz"), new LichSuLamViec(new DateTime(2022, 03, 07), "asd, phố mnk") }),
            new NguoiGiupViec("Nguyen Thi E", "0912345456", "Chăm người già, chăm người bệnh, chăm em bé, dọn nhà lầu, nấu ăn", 3000000, null, new List<LichSuLamViec> { new LichSuLamViec(new DateTime(2021, 01, 14), "abc, phố xyz"), new LichSuLamViec(new DateTime(2022, 03, 07), "asd, phố mnk") }),
            new NguoiGiupViec("Nguyen Thi F", "0912343459", "Chăm người già, dọn nhà lầu, nấu ăn", 3000000, null, new List<LichSuLamViec> { new LichSuLamViec(new DateTime(2021, 01, 14), "abc, phố xyz"), new LichSuLamViec(new DateTime(2022, 03, 07), "asd, phố mnk") })
        };

        public FormDanhSach()
        {
            InitializeComponent();
        }

        private void buttonHienThiDsNguoiThue_Click(object sender, EventArgs e)
        {
            dataGridViewNguoiThue.DataSource = dsnguoithue;
            dataGridViewNguoiThue.Columns[0].HeaderText = "Họ và Tên";
            dataGridViewNguoiThue.Columns[1].HeaderText = "Số điện thoại";
            dataGridViewNguoiThue.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewNguoiThue.Columns[3].HeaderText = "Yêu cầu";
            dataGridViewNguoiThue.Columns[4].HeaderText = "Gíá cả";
            dataGridViewNguoiThue.Columns[5].HeaderText = "Chế độ thưởng";
            dataGridViewNguoiThue.Columns[6].HeaderText = "Đánh giá";
            dataGridViewNguoiThue.SelectionChanged += dataGridViewNguoiThue_SelectionChanged;
        }

        private void dataGridViewNguoiThue_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNguoiThue.SelectedRows.Count > 0)
            {
                NguoiThue nguoiThue = dataGridViewNguoiThue.SelectedRows[0].DataBoundItem as NguoiThue;

                if (nguoiThue != null)
                {
                    dataGridViewLichSuThue.DataSource = nguoiThue.LichSuThue;
                    dataGridViewLichSuThue.Columns[0].HeaderText = "Ngày thuê";
                    dataGridViewLichSuThue.Columns[1].HeaderText = "Tên người đã thuê";
                }
                else
                {
                    dataGridViewLichSuThue.DataSource = null;
                }
            }
        }

        private void buttonTimNguoiThue_Click(object sender, EventArgs e)
        {
            string yeuCau = textBoxYeuCau.Text.ToLower();
            string thuong = textBoxThuong.Text.ToLower();
            List<NguoiThue> ketQuaTimKiem = new List<NguoiThue>();
            foreach (NguoiThue nguoiThue in dsnguoithue)
            {
                ketQuaTimKiem = nguoiThue.TimNguoiThueTheoYeuCauVaThuong(dsnguoithue, yeuCau, thuong);
            }
            dataGridViewNguoiThue.DataSource = ketQuaTimKiem;
        }

        private void buttonThemDanhGiaNguoiThue_Click(object sender, EventArgs e)
        {
            if (dataGridViewNguoiThue.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một người thuê để tạo hợp đồng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NguoiThue nguoiThue = dataGridViewNguoiThue.SelectedRows[0].DataBoundItem as NguoiThue;
            string danhGia = textBoxDanhGiaNguoiThue.Text.ToLower();

            nguoiThue.ThemDanhGiaNguoiThue(danhGia);
            dataGridViewLichSuThue.DataSource = nguoiThue;
            textBoxDanhGiaNguoiThue.Clear();
        }

        private void buttonTaoHopDongNguoiThue_Click(object sender, EventArgs e)
        {
            if (dataGridViewNguoiThue.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một người thuê để tạo hợp đồng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NguoiThue nguoiThue = dataGridViewNguoiThue.SelectedRows[0].DataBoundItem as NguoiThue;

            using (FormTaoHopDong formHopDong = new FormTaoHopDong())
            {
                if (formHopDong.ShowDialog() == DialogResult.OK)
                {
                    nguoiThue.ThemLichSuThue(formHopDong.NewHopDong.NguoiGiupViec.HoTen);

                    MessageBox.Show("Tạo hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonHienThiNguoiGiupViec_Click(object sender, EventArgs e)
        {
            dataGridViewNguoiGiupViec.DataSource = dsnguoigiupviec;
            dataGridViewNguoiGiupViec.Columns[0].HeaderText = "Họ và Tên";
            dataGridViewNguoiGiupViec.Columns[1].HeaderText = "Số điện thoại";
            dataGridViewNguoiGiupViec.Columns[2].HeaderText = "Năng lực";
            dataGridViewNguoiGiupViec.Columns[3].HeaderText = "Mức giá";
            dataGridViewNguoiGiupViec.Columns[4].HeaderText = "Đánh giá";
            dataGridViewNguoiGiupViec.SelectionChanged += dataGridViewNguoiGiupViec_SelectionChanged;
        }

        private void dataGridViewNguoiGiupViec_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNguoiGiupViec.SelectedRows.Count > 0)
            {
                NguoiGiupViec nguoiGiupViec = dataGridViewNguoiGiupViec.SelectedRows[0].DataBoundItem as NguoiGiupViec;

                if (nguoiGiupViec != null)
                {
                    dataGridViewLichSuLamViec.DataSource = nguoiGiupViec.LichSuLamViec;
                    dataGridViewLichSuLamViec.Columns[0].HeaderText = "Ngày làm việc";
                    dataGridViewLichSuLamViec.Columns[1].HeaderText = "Nơi đã làm việc";
                }
                else
                {
                    dataGridViewLichSuLamViec.DataSource = null;
                }
            }
        }

        private void buttonTimNangLuc_Click(object sender, EventArgs e)
        {
            string nangLuc = textBoxNangLuc.Text.ToLower();
            List<NguoiGiupViec> ketQuaTimKiem = new List<NguoiGiupViec>();
            foreach (NguoiGiupViec nguoiGiupViec in dsnguoigiupviec)
            {
                ketQuaTimKiem = nguoiGiupViec.TimNguoiGiupViecTheoNangLuc(dsnguoigiupviec, nangLuc);
            }
            dataGridViewNguoiGiupViec.DataSource = ketQuaTimKiem;
        }

        private void buttonThemDanhGiaNguoiGiupViec_Click(object sender, EventArgs e)
        {
            if (dataGridViewNguoiGiupViec.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một người thuê để tạo hợp đồng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NguoiGiupViec nguoiGiupViec = dataGridViewNguoiGiupViec.SelectedRows[0].DataBoundItem as NguoiGiupViec;
            string danhGia = textBoxDanhGiaNguoiGiupViec.Text.ToLower();

            nguoiGiupViec.ThemDanhGiaNguoiGiupViec(danhGia);
            dataGridViewLichSuLamViec.DataSource = nguoiGiupViec;
            textBoxDanhGiaNguoiGiupViec.Clear();
        }

        private void buttonTaoHopDongNguoiGiupViec_Click(object sender, EventArgs e)
        {
            if (dataGridViewNguoiGiupViec.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một người thuê để tạo hợp đồng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NguoiGiupViec nguoiGiupViec = dataGridViewNguoiGiupViec.SelectedRows[0].DataBoundItem as NguoiGiupViec;

            using (FormTaoHopDong formHopDong = new FormTaoHopDong())
            {
                if (formHopDong.ShowDialog() == DialogResult.OK)
                {
                    string tenNguoiGiupViec = formHopDong.GetTenNguoiGiupViec();
                    nguoiGiupViec.ThemLichSuLamViec(tenNguoiGiupViec);

                    MessageBox.Show("Tạo hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonHienThiDsHopDong_Click(object sender, EventArgs e)
        {
            using (FormDanhSachHopDong formdsHopDong = new FormDanhSachHopDong())
            {
                formdsHopDong.ShowDialog();
            }
        }
    }
}