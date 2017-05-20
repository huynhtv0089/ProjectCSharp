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
            NhanVien v1 = new NhanVien("nguyen van a", "giam doc", new Date(8,12,1990), 3.0);
            NhanVien v2 = new NhanVien("nguyen van b", "pho giam doc", new Date(5, 3, 1995), 2.0);
            NhanVien v3 = new NhanVien("Pham thi c", "bao ve", new Date(2, 11, 1995), 3.0);
            NhanVien v4 = new NhanVien("Hong kim Hoa", "Ke toan", new Date(15, 07, 1990), 4.0);
            NhanVien v5 = new NhanVien("Bui nhat huy", "Nhan su", new Date(20, 09, 1987), 1.0);
            NhanVien v6 = new NhanVien("Bo kinh van", "le tan", new Date(30, 04, 1987), 5.0);
            NhanVien v7 = new NhanVien("Hac dieu", "ky thuat", new Date(15, 02, 1987), 4.0);

            Element e1 = new Element(v1);
            Element e2 = new Element(v2);
            Element e3 = new Element(v3);
            Element e4 = new Element(v4);
            Element e5 = new Element(v5);
            Element e6 = new Element(v6);

            //Element e7 = new Element(v7);
            LinkedList ll = new LinkedList();
            /*Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ll.nhapNV();
            }
            ll.printList();*/
            
            ll.insertTail(e1);
            ll.insertTail(e2);
            ll.insertTail(e3);
            ll.insertTail(e4);
            ll.insertTail(e5);
            ll.insertTail(e6);
            ll.printList();
            /*LinkedList ll = new LinkedList();
            Console.WriteLine("-----------------");
            ll.docFile();
            ll.printList();*/

            //Console.WriteLine("Nhap vao vi tri can chen: ");
            //int index = int.Parse(Console.ReadLine());
     
            //Console.WriteLine("Nhan ky tu: ");
            //string strName = Console.ReadLine();
            //ll.timKiem(strName);
            //Console.WriteLine("-----------------");

            /*Console.WriteLine("Nhap vao vi tri can chen: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------");
            ll.chenNV(index, e7);
            ll.printList();*/

            //ll.xoaNV(strName);
            
            //ll.deleteAfter(e2, e3); //insertTail - remove e3
            //ll.deleteAfter(e3, e2); //insertFirst - remove e2
            
            /*Console.WriteLine("Nhan ky tu: ");
            string strName = Console.ReadLine();
            Console.WriteLine("-----------------");
            ll.xoaNV(strName);
            ll.printList();*/

            /*Console.WriteLine("-----------------");
            Console.WriteLine("Danh sach da sap xep");
            Console.WriteLine("-----------------");
            ll.sapXep();
            ll.printList();*/

            Console.ReadKey();
        }
    }
}
