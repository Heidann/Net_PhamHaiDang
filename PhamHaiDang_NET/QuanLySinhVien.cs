using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamHaiDang_NET
{
    class QuanLySinhVien
    {
        List<SinhVien> listSV = new List<SinhVien>();
       

        private int GenerateID()
        {
            int max = 1;
            if (listSV != null && listSV.Count > 0)
            {
                max = listSV[0].MaSV;
                foreach (SinhVien sv in listSV)
                {
                    if (max < sv.MaSV)
                    {
                        max = sv.MaSV;
                    }
                }
                max++;
            }
            return max;
        }
        public void NhapSinhVien()
        {
            // Khởi tạo một sinh viên mới
            SinhVien sv = new SinhVien();
            sv.MaSV = GenerateID();
            Console.Write("Nhap ten sinh vien: ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap diem ly thuyet: ");
            sv.DiemLT = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem thuc hanh: ");
            sv.DiemTH = Convert.ToDouble(Console.ReadLine());
            DiemTB(sv);
            listSV.Add(sv);
        }
        private void DiemTB(SinhVien sv)
        {
            double DiemTB = (sv.DiemLT + sv.DiemTH ) / 2;
            sv.DiemTB = DiemTB;
        }
        public void ShowSinhVien(List<SinhVien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5}  {4, 5}", "MaSV", "Name", "DiemLT", "DiemTH", "DiemTB");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} ", sv.MaSV, sv.Name, sv.DiemLT, sv.DiemTH, sv.DiemTB);
                }
            }
            Console.WriteLine();
        }
        public List<SinhVien> getListSinhVien()
        {
            return listSV;
        }


    }

    

}
