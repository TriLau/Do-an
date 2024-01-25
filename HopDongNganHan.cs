using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DoAnCuoiKy
{
    public class HopDongNganHan : HopDong
    {
        private string giolam;
        private string calam;

        public string GioLam
        {
            get { return giolam; } 
            set { giolam = value;}
        }

        public string CaLam
        {
            get { return calam; }
            set { calam = value;}
        }

        public HopDongNganHan() { }

        public void DonDepTheoGio(string gioLam)
        {
            Loai = "Theo gio";
            GioLam = gioLam;
        }

        public void DonDepTheoCa(string caLam)
        {
            Loai = "Theo gio";
            GioLam = caLam;
        }
    }
}
