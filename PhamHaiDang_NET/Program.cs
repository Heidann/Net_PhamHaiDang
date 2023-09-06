using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamHaiDang_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
            //int n = 0;
            //Console.WriteLine("\n1. So luong sinh vien muon them");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1;i<=n;i++)
            //{
            //    Console.WriteLine("\n1. Them sinh vien {0}",i);
            //    quanLySinhVien.NhapSinhVien();
            //}
            //Console.WriteLine("\nThem sinh vien thanh cong!");

            //Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
            //quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
            //Console.ReadLine();

            Console.OutputEncoding = Encoding.Unicode;
            ToaDo td = new ToaDo("ABC",5,5);
            HinhTron ht = new HinhTron(td,10.5);
            Console.WriteLine(ht.ToString());
            Console.ReadLine();


            Product p1

           



        }
    }
}
