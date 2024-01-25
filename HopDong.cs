using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public class HopDong
    {
        private NguoiThue nguoiThue = new NguoiThue();
        private NguoiGiupViec nguoiGiupViec = new NguoiGiupViec();
        private DateTime ngaybatdau;
        private DateTime ngayketthuc;
        protected string loai;

        public string TenNguoiThue
        {
            get { return nguoiThue.HoTen; }
            set { nguoiThue.HoTen = value; }
        }

        public string TenNguoiGiupViec
        {
            get { return nguoiGiupViec.HoTen; }
            set { nguoiGiupViec.HoTen = value; }
        }

        public DateTime NgayBatDau
        {
            get { return ngaybatdau; }
            set { ngaybatdau = value; }
        }

        public DateTime NgayKetThuc
        {
            get { return ngayketthuc; }
            set { ngayketthuc = value; }
        }

        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }

        public NguoiThue NguoiThue
        {
            get { return nguoiThue; }
            set { nguoiThue = value;}
        }

        public NguoiGiupViec NguoiGiupViec
        {
            get { return nguoiGiupViec; }
            set { nguoiGiupViec = value; }
        }

        public HopDong() { }

        public HopDong(string tenNguoiThue, string tenNguoiGV, DateTime nbd, DateTime nkt, string loai) 
        {
            TenNguoiThue = tenNguoiThue;
            TenNguoiGiupViec = tenNguoiGV;
            NgayBatDau = nbd;
            NgayKetThuc = nkt;
            Loai = loai;
        }

        public void TaoHopDongMoi(string ten, string sdt)
        {
            if (NguoiGiupViec == null || NguoiThue == null)
            {
                NguoiGiupViec = new NguoiGiupViec();
                NguoiThue = new NguoiThue();
            }

            NguoiGiupViec.HoTen = ten;
            NguoiGiupViec.Sdt = sdt;


            NguoiGiupViec.HoTen = ten;
            NguoiThue.Sdt = sdt;

            NgayBatDau = DateTime.Now;
            NgayBatDau = DateTime.Now.AddMonths(3);
        }

        public void TaiHopDong()
        {
            if (NgayKetThuc <= DateTime.Now)
            {
                NgayBatDau = DateTime.Now;
                NgayKetThuc = DateTime.Now.AddMonths(3);
            }
        }

        public void HuyHopDong(List<HopDong> dshopdong, HopDong hopDongDaChon)
        {
            dshopdong.Remove(hopDongDaChon);
        }
    }
}
