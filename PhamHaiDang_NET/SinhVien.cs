using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamHaiDang_NET
{
    class SinhVien
    {
        public int MaSV { get; set; }
        public string Name { get; set; }
        public double DiemLT { get; set; }
        public double DiemTH { get; set; }
        public double DiemTB { get; set; }



        public SinhVien()
        {
            this.MaSV = MaSV;
            this.Name = Name;
            this.DiemLT = DiemLT;
            this.DiemTH = DiemTH;
            this.DiemTB = DiemTB;
        }
        public SinhVien(int maSV, string name, double diemLT, double diemTH , double diemTB)
        {
            MaSV = maSV;
            Name = name;
            DiemLT = diemLT;
            DiemTH = diemTH;
            DiemTB = diemTB;

        }
       



    }
}
