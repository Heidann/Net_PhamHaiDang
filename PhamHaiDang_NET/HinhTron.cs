using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhamHaiDang_NET
{
    class HinhTron
    {
        private ToaDo _tam ;

        private double _banKinh;
        public ToaDo Tam
        {
            get
            {
                return _tam;
            }
            set
            {
                _tam = value;
            }
        }
        public double BanKinh
        {
            get
            {
                return _banKinh;
            }
            set
            {
                _banKinh = value;
            }
        }


        public  HinhTron()
        {

            this._tam = new ToaDo(5, 6);
        }
        public HinhTron(ToaDo A, double BanKinh)
        {
            this._tam = A;
            this._banKinh = BanKinh;
        }
        public double TinhChuVi()
        {
            return (2 * Math.PI * _banKinh);
        }
        public double TinhDienTich()
        {
            return Math.PI * _banKinh * _banKinh; ;
        }
        public override string ToString()
        {
            String str = String.Format("Hình tròn có tâm {0} với bán kính {1} có diện tích và chu vi lần lượt là {2} và {3}",Tam,BanKinh,TinhChuVi(),TinhDienTich() );
            return str;
        }



    }
}
