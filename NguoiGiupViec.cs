using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class NguoiGiupViec : Nguoi
    {
        private string nangluc;
        private List<LichSuLamViec> lichsulamviec;
        private int muc;
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

        public string NangLuc
        {
            get { return this.nangluc; }
            set { this.nangluc = value; }
        }

        public int MucGia
        {
            get { return this.muc; }
            set { this.muc = value; }
        }

        public List<LichSuLamViec> LichSuLamViec
        {
            get { return this.lichsulamviec; }
            set { this.lichsulamviec = value; } 
        }

        public string DanhGia
        {
            get { return danhgia; }
            set { danhgia = value; }
        }

        public NguoiGiupViec() { }

        public NguoiGiupViec(string hoten, string sdt, string nangluc, int muc, string danhgia, List<LichSuLamViec> lslv) : base(hoten, sdt)
        {
            NangLuc = nangluc;
            MucGia = muc;
            DanhGia = danhgia;
            LichSuLamViec = lslv;
        }

        public List<NguoiGiupViec> TimNguoiGiupViecTheoNangLuc(List<NguoiGiupViec> dsnguoigiupviec, string nangLuc)
        {
            return dsnguoigiupviec.Where(nguoiGiupViec => nguoiGiupViec.NangLuc.ToLower().Contains(nangLuc)).ToList();
        }

        public void ThemDanhGiaNguoiGiupViec(string danhGia)
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

        public void ThemLichSuLamViec(string tenNguoiTaoHopDong)
        {
            lichsulamviec.Add(new LichSuLamViec(DateTime.Now, tenNguoiTaoHopDong));
        }
    }
}
