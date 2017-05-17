using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class QuanLy
    {
        List<NhanVien> list;

        public QuanLy()
        {
            list = new List<NhanVien>();
        }

        public NhanVien nhapNV()
        {
            NhanVien nv = new NhanVien();
            string hoTen = null, chucVu = null;
            int ngay = 0, thang = 0, nam = 0;
            double heSoLuong = 0;

            Console.WriteLine("Nhap Ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu: ");
            chucVu = Console.ReadLine();
            Console.WriteLine("Nhap ngay thang nam sinh: ");
            Console.WriteLine("Nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong: ");
            heSoLuong = double.Parse(Console.ReadLine());

            nv.setHoTen(hoTen);
            nv.setChucVu(chucVu);
            nv.setNgayThangNamSinh(new Date(ngay, thang, nam));
            nv.setHeSoLuong(heSoLuong);

            return nv;
        }

        public void themNV(NhanVien nv)
        {
            list.Add(nv);
        }

        public void hienThi()
        {
            foreach (NhanVien n in list)
            {
                Console.WriteLine(n.ToString());
            }
        }

        public void ghiFile()
        {
            FileInfo fi = new FileInfo("D:\\vidu.txt");
            StreamWriter sw = fi.CreateText();
            foreach (NhanVien n in list)
                sw.WriteLine(n.getHoTen() + "|" + n.getChucVu() + "|" + n.getNgayThangNamSinh() + "|" + n.getHeSoLuong());
            //sw.Write(sw.NewLine);
            sw.Close();
        }

        public void docFile()
        {
            string[] lines = System.IO.File.ReadAllLines("D:\\vidu.txt");
            NhanVien nv = new NhanVien();

            for (int i = 0; i < lines.Length; i++)
            {
                //Split line
                String[] arrLine = lines[i].Split('|');
                //Split date
                String[] arrDate = arrLine[2].Split('/');
                int ngay = int.Parse(arrDate[0]);
                int thang = int.Parse(arrDate[1]);
                int nam = int.Parse(arrDate[2]);

                nv.setHoTen(arrLine[0]);
                nv.setChucVu(arrLine[1]);
                nv.setNgayThangNamSinh(new Date(ngay, thang, nam));
                nv.setHeSoLuong(double.Parse(arrLine[3]));

                this.themNV(nv);
            }
        }

        public void capNhatVitri()
        {
            int i = 1;
            foreach(NhanVien n in list) {
                n.setViTri(i);
                i+=1;
            }
        }

        public int[] timViTri(string str)
        {
            this.capNhatVitri();
            int[] vitri = new int[list.Count];
            int i=0;
            foreach (NhanVien n in list)
            {
                if (n.getHoTen().IndexOf(str) != -1)
                {
                    vitri[i] = n.getViTri();
                    i++;
                }
                else if (n.getChucVu().IndexOf(str) != -1)
                {
                    vitri[i] = n.getViTri();
                    i++;
                }
                else if (Convert.ToString(n.getHeSoLuong()).IndexOf(str) != -1)
                {
                    vitri[i] = n.getViTri();
                    i++;
                }
                else if (Convert.ToString(n.getNgayThangNamSinh().Ngay).IndexOf(str) != -1)
                {
                    vitri[i] = n.getViTri();
                    i++;
                }
                else if (Convert.ToString(n.getNgayThangNamSinh().Thang).IndexOf(str) != -1)
                {
                    vitri[i] = n.getViTri();
                    i++;
                }
                else if (Convert.ToString(n.getNgayThangNamSinh().Nam).IndexOf(str) != -1)
                {
                    vitri[i] = n.getViTri();
                    i++;
                }
               
            }
            return vitri;
        }

        public void timKiem(string str)
        {
            int[] tmp = this.timViTri(str);
          
            foreach (NhanVien n in list)
                for (int i = 0; i < tmp.Length; i++)
                    if (n.getViTri() == tmp[i])
                        Console.WriteLine(n.ToString());
        }

        public void xoaNV(string str)
        {
            int[] tmp = this.timViTri(str);
            int count = 0;
            for (int i = 0; i < tmp.Length; i++)
                if (tmp[i] != 0)
                    count++;

            Console.WriteLine(" -- " + count);

            int getPos = 0;
            for (int i = 0; i < count; i++)
            {
                getPos = this.timViTri(str)[0];
                if (getPos != 0)
                    list.RemoveAt(getPos-1);
            }
        }

        public void chenNV(int viTri, NhanVien n)
        {
            list.Insert(viTri-1, n);
        }

        public void sapXepHSL()
        {

            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i].getNgayThangNamSinh().Thang > list[j].getNgayThangNamSinh().Thang)
                    {
                        NhanVien tmp = list[i];
                        list[i] = list[j];
                        list[j] = tmp;
                    }
                }
            }

            this.hienThi();
        }














    }
}
