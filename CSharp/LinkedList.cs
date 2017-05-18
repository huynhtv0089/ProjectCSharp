using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class LinkedList
    {
        private Element head;
	    private Element tail;
	    private int nNumber;

        public LinkedList()
        {
		    head = null;
		    tail = null;
		    nNumber = 0 ;
	    }
	
	    public void insertFrist(Element n) {
		    if(head == null)
			    tail = n;
		    else 
			    head.setPrePtr(n);
		    n.setNextPtr(head);
		    head = n;
		    this.nNumber++;
	    }
	
	    public void insertTail(Element n) {
		    if(tail == null)
			    head =  n;
		    else
			    tail.setNextPtr(n);
		
		    n.setPrePtr(tail);
		    tail = n;
		    this.nNumber++;
	    }
	
	
	    public Element deleteFirst() {
		    Element p = head;
		    head = head.getNextPtr();
		    this.nNumber--;
		    return p;
	    }
	
	    public Element deleteTail() {
		    Element p = tail;
		    tail = tail.getPrePtr();
		    this.nNumber--;
		    return p;
	    }
	
	    public void printList() {
		    Element p = head;
		    while(p != null) {
			    Console.WriteLine(p.getData() + " ");
			    p = p.getNextPtr();
		    }
	    }

        public int size()
        {
            Element p = head;
            int i = 0;
            while (p != null)
            {
                i++;
                p = p.getNextPtr();
            }
            return i;
        }
	
	    public void insertAfter(Element p, Element n) {
		    Element y = p.getNextPtr();
		    if(p.getNextPtr() != null) {
			    p.setNextPtr(n);
			    n.setPrePtr(p);
			    n.setNextPtr(y);
			    y.setPrePtr(n);
		    }else {
			    this.insertTail(n);
		    }		
	    }

        public Element deleteAfter(Element e, Element n)
        {
            Element p = null;

            if (e.getNextPtr() != null)
            {
                p = e.getNextPtr();
                e.setNextPtr(n.getNextPtr());
                return p;
            }
            else
            {
                p = e.getNextPtr();
                n.setNextPtr(e.getNextPtr());
                return p;
            }
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

        public void ghiFile()
        {
            FileInfo fi = new FileInfo("D:\\vidu.txt");
            StreamWriter sw = fi.CreateText();

            Element p = head;
            while(p != null)
            {
                sw.WriteLine(p.getData().getHoTen() + "|" + p.getData().getChucVu() + "|" + p.getData().getNgayThangNamSinh() + "|" + p.getData().getHeSoLuong());
                p = p.getNextPtr();
            }
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

                Element e = new Element(nv);
                this.insertTail(e);
            }
        }

        public void capNhatVitri()
        {
            int i = 1;
            Element p = head;
            while(p != null)
            {
                p.getData().setViTri(i);
                i += 1;
                p = p.getNextPtr();
            }
        }

        public int[] timViTri(string str)
        {
            this.capNhatVitri();
            int[] vitri = new int[this.size()];
            int i = 0;
            Element p = head;
            while(p !=null)
            {
                if (p.getData().getHoTen().IndexOf(str) != -1)
                {
                    vitri[i] = p.getData().getViTri();
                    i++;
                }
                else if (p.getData().getChucVu().IndexOf(str) != -1)
                {
                    vitri[i] = p.getData().getViTri();
                    i++;
                }
                else if (Convert.ToString(p.getData().getHeSoLuong()).IndexOf(str) != -1)
                {
                    vitri[i] = p.getData().getViTri();
                    i++;
                }
                else if (Convert.ToString(p.getData().getNgayThangNamSinh().Ngay).IndexOf(str) != -1)
                {
                    vitri[i] = p.getData().getViTri();
                    i++;
                }
                else if (Convert.ToString(p.getData().getNgayThangNamSinh().Thang).IndexOf(str) != -1)
                {
                    vitri[i] = p.getData().getViTri();
                    i++;
                }
                else if (Convert.ToString(p.getData().getNgayThangNamSinh().Nam).IndexOf(str) != -1)
                {
                    vitri[i] = p.getData().getViTri();
                    i++;
                }
                p = p.getNextPtr();
            }
            return vitri;
        }

        public void timKiem(string str)
        {
            int[] tmp = this.timViTri(str);
            Element p = head;
            while (p != null)
            {
                for (int i = 0; i < tmp.Length; i++)
                    if (p.getData().getViTri() == tmp[i])
                        Console.WriteLine(p.getData().ToString());
                p = p.getNextPtr();
            }
        }

        public void xoaNV(string str)
        {
            int[] tmp = this.timViTri(str);
            int count = 0;
            for (int i = 0; i < tmp.Length; i++)
                if (tmp[i] != 0)
                    count++;

            Console.WriteLine("Tim thay " + count + "Nhan vien can xoa. ");

            Element p = head;
            Element n = null;
            int getPos = 0;
            while(p != null) {
                getPos = this.timViTri(str)[0];
                if (getPos != 0)
                {
                    if (p.getData().getViTri() == (getPos - 1))
                    {
                        //Console.WriteLine(getPos - 1);
                        n = p;
                    }
                    if (p.getData().getViTri() == getPos)
                    {
                        this.deleteAfter(n, p);
                        //Console.WriteLine(getPos);
                    }
                }
                p = p.getNextPtr();
            }
        }

        public void chenNV(int viTri, Element n)
        {
            this.capNhatVitri();
            //int[] tmp = this.timViTri(str);
            Element p = head;
            while(p != null) {
                if((viTri-1) == p.getData().getViTri()) {
                    this.insertAfter(p,n);
                }
                p = p.getNextPtr();
            }
        }

        public void sapXep()
        {

            for (Element p = head; p != tail.getNextPtr(); p = p.getNextPtr())
            {
                for (Element q = p.getNextPtr(); q != null; q = q.getNextPtr())
                {
                    if(p.getData().getNgayThangNamSinh().Nam > q.getData().getNgayThangNamSinh().Nam) {
                        Element e = p;
                        p = q;
                        q = e;
                    }
                }
            }

        }




    }
}
