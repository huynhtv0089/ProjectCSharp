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

        public int Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }

        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }

        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }

        public override string ToString()
        {
            return ngay + "/" + thang + "/" + nam;
        }
    }
}
