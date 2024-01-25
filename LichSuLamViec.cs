using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class LichSuLamViec
    {
        private DateTime ngaylamviec;
        private string noidalamviec;

        public DateTime NgayLamViec
        {
            get { return ngaylamviec; }
            set { ngaylamviec = value; }
        }

        public string NoiDaLamViec
        {
            get { return noidalamviec; }
            set { noidalamviec = value; }
        }

        public LichSuLamViec() { }

        public LichSuLamViec(DateTime ngaylamviec, string noidalamviec)
        {
            NgayLamViec = ngaylamviec;
            NoiDaLamViec = noidalamviec;
        }
    }
}
