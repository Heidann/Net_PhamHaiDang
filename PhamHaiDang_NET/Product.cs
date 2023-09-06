using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamHaiDang_NET
{
    class Product
    {
        private string _desciption;
        private string _productID;
        private double _price;

        public string Desciption
        {
            get
            {
                return _desciption;
            }
            set
            {
                _desciption = value;
            }
        }
        public string ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public Product()
        {
            this._desciption = "";
            this._productID = "";
            this._price = 0;
        }
        public Product(string Desciption, string ProductID, double Price )
        {
            this._desciption = Desciption;
            this._productID = ProductID;
            this._price = Price;

        }
        public override string ToString()
        {
            
            String str = String.Format("" );
            return str;
        }

    }
}
