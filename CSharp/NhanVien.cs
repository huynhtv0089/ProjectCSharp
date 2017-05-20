using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class NhanVien
    {
        private string hoTen;
        private string chucVu;
        private Date ngayThangNamSinh;
        private double heSoLuong;
        private int viTri;

        public NhanVien() {}

        public NhanVien(string hoten, string chucvu, Date date, double hesoluong)
        {
            this.hoTen = hoten;
            this.chucVu = chucvu;
            this.ngayThangNamSinh = date;
            this.heSoLuong = hesoluong;
        }

        public void setHoTen(string hoten)
        {
            this.hoTen = hoten;
        }
        public string getHoTen()
        {
            return this.hoTen;
        }

        public void setChucVu(string chucVu)
        {
            this.chucVu = chucVu;
        }
        public string getChucVu()
        {
            return this.chucVu;
        }

        internal void setNgayThangNamSinh(Date date)
        {
            this.ngayThangNamSinh = date;
        }
        internal Date getNgayThangNamSinh()
        {
            return this.ngayThangNamSinh;
        }

        public void setHeSoLuong(double heSoLuong)
        {
            this.heSoLuong = heSoLuong;
        }
        public double getHeSoLuong()
        {
            return this.heSoLuong;
        }

        public void setViTri(int viTri)
        {
            this.viTri = viTri;
        }
        public int getViTri()
        {
            return this.viTri;
        }

        public override string ToString()
        {
            //return hoTen + "\t" + chucVu + "\t" + ngayThangNamSinh + "\t"+ heSoLuong;
            return string.Format("{0,-19}{1,-20}{2,-20}{3,5}", hoTen, chucVu, ngayThangNamSinh, heSoLuong);
        }
    }
}
