using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class Nguoi
    {
        protected string hoten;
        protected string sdt;

        public Nguoi() { }

        public Nguoi(string hoten, string sdt)
        {
            this.hoten = hoten;
            this.sdt = sdt;
        }
    }
}
