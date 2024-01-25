using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class LichSuThue
    {
        private DateTime ngaythue;
        private string tennguoidathue;

        public DateTime NgayThue
        {
            get { return ngaythue; }
            set { ngaythue = value; }
        }

        public string TenNguoiDaThue
        {
            get { return  tennguoidathue; }
            set { tennguoidathue = value; }
        }

        public LichSuThue() { }

        public LichSuThue(DateTime ngaythue, string tennguoidathue)
        {
            NgayThue = ngaythue;
            TenNguoiDaThue = tennguoidathue;
        }
    }
}
