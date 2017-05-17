using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien v1 = new NhanVien("nguyen van a", "giam doc", new Date(8,12,1990), 3.1);
            NhanVien v2 = new NhanVien("nguyen van b", "pho giam doc", new Date(5, 3, 1995), 2.5);
            NhanVien v3 = new NhanVien("Pham thi c", "bao ve", new Date(2, 11, 1995), 3.0);
            NhanVien v4 = new NhanVien("Hong kim Hoa", "Ke toan", new Date(15, 07, 1990), 4.0);
            NhanVien v5 = new NhanVien("Bui nhat huy", "Nhan su", new Date(20, 09, 1985), 1.0);
            NhanVien v6 = new NhanVien("Bo kinh van", "le tan", new Date(30, 04, 1987), 5.0);

            NhanVien v7 = new NhanVien("Hac dieu", "ky thuat", new Date(15, 02, 1987), 4.0);

            QuanLy ql = new QuanLy();
            /*Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {  
                ql.themNV(ql.nhapNV());
            }*/
            ql.themNV(v1);
            ql.themNV(v2);
            ql.themNV(v3);
            ql.themNV(v4);
            ql.themNV(v5);
            ql.themNV(v6);
            ql.hienThi();
            ql.ghiFile();

            /*
            Console.WriteLine("---- Tim kiem ---");
            Console.WriteLine("Nhap chuoi can tiem kiem: ");
            string strName = Console.ReadLine();
            Console.WriteLine("-----------------");
            ql.timKiem(strName); */

            /*Console.WriteLine("Nhap chuoi can xoa: ");
            string strName = Console.ReadLine();
            ql.xoaNV(strName);
            Console.WriteLine("\nDanh sach sau khi xoa");
            ql.hienThi();*/

            /*Console.WriteLine("Nhap vao vi tri can chen: ");
            int index = int.Parse(Console.ReadLine());
            ql.chenNV(index, v7);
            Console.WriteLine("\nDanh sach sau khi chen: ");
            ql.hienThi();*/
            
            Console.WriteLine("\nDanh sach sau sap xep he so luon: ");
            ql.sapXepHSL();

            //ql.docFile();
            //ql.hienThi();

            Console.ReadKey();
        }
    }
}
