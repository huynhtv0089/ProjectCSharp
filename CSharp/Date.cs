using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Date
    {
        private int ngay;
        private int nam;
        private int thang;

        public Date() { }
        public Date(int ngay, int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }

        public int getNgay()
        {
            return ngay;
        }
        public void setNgay(int ngay)
        {
            this.ngay = ngay;
        }

        public int getThang()
        {
            return thang;
        }
        public void setThang(int thang)
        {
            this.thang = thang;
        }

        public int getNam()
        {
            return nam;
        }
        public void setNam(int nam)
        {
            this.nam = nam;
        }

        public override string ToString()
        {
            return ngay + "/" + thang + "/" + nam;
        }
    }
}
