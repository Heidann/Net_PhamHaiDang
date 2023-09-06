using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamHaiDang_NET
{
    class ToaDo
    {
        private string _ten;
        private float _x;
        private float _y;
        public string Ten 
        {
            get
            {
                return _ten;
            }
            set
            {
                _ten = value;
            }
        }
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        
        public ToaDo()
        {
            this._ten = "A";
            this._x = 2;
            this._y = 3;
            
        }
        public ToaDo(string Ten,float X, float Y)
        {
            _ten = Ten;
            _x = X;
            _y = Y;
        }
        public ToaDo(float X, float Y)
        {
            _x = X;
            _y = Y;
        }
        public override string ToString()
        {
            String str = String.Format("{0}({1},{2})", Ten, X, Y);
            return str;

        }

        
    }
}
