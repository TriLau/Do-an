using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class NguoiThue : Nguoi
    {
        private string diachi;
        private string yeucau;
        private List<LichSuThue> lichsuthue;
        private int gia;
        private string chedothuong;
        private string danhgia;

        public string HoTen
        {
            get { return this.hoten; }
            set { this.hoten = value; }
        }

        public string Sdt
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string YeuCau
        {
            get { return this.yeucau; }
            set { this.yeucau = value; }
        }

        public int Gia
        {
            get { return this.gia; }
            set { this.gia = value; }
        }

        public string CheDoThuong
        {
            get { return this.chedothuong; }
            set { this.chedothuong = value; }
        }

        public string DanhGia
        {
            get { return this.danhgia;}
            set { this.danhgia = value;}
        }

        public List<LichSuThue> LichSuThue
        {
            get { return this.lichsuthue; }
            set { this.lichsuthue = value; }
        }

        public NguoiThue() { }

        public NguoiThue(string hoten, string sdt, string diachi, string yeucau, int gia, string chedothuong, string danhgia, List<LichSuThue> lst) : base(hoten, sdt)
        {
            DiaChi = diachi;
            YeuCau = yeucau;
            Gia = gia;
            CheDoThuong = chedothuong;
            DanhGia = danhgia;
            LichSuThue = lst;
        }

        public List<NguoiThue> TimNguoiThueTheoYeuCauVaThuong(List<NguoiThue> dsnguoithue, string yeucau, string thuong)
        {
            return dsnguoithue.Where(nguoiThue => nguoiThue.YeuCau.ToLower().Contains(yeucau) && nguoiThue.CheDoThuong.ToLower().Contains(thuong)).ToList();
        }

        public void ThemDanhGiaNguoiThue(string danhGia) 
        {
            if (danhgia == null)
            {
                danhgia = danhGia;
            }
            else
            {
                danhgia += ", " + danhGia;
            }
        }

        public void ThemLichSuThue(string tenNguoiTaoHopDong)
        {
           lichsuthue.Add(new LichSuThue(DateTime.Now, tenNguoiTaoHopDong));
        }
    }
}
