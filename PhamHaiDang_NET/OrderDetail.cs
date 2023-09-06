using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamHaiDang_NET
{
    class OrderDetail
    {
        private int _quatity;
        private Product _product;

        public int Quatity
        {
            get
            {
                return _quatity;
            }
            set
            {
                _quatity = value;
            }
        }
        public Product Product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
            }
        }

        

        public OrderDetail(Product p, int q)
        {
            this._quatity = q;
            this._product = p;
        }
        public double CalcTotalPrice()
        {

            return _quatity * _product.Price;
        }
        public override string ToString()
        {
              
            String str = String.Format("{0} \t | {1} \t | {2} \t | {3} \t | {4} \t ", _product.ProductID,_product.Desciption, _product.Price, _quatity, CalcTotalPrice());
            return str;

        }


    }
}
