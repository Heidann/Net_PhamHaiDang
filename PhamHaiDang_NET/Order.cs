using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PhamHaiDang_NET
{
    class Order
    {
        private int _orderID;
        private DateTime _orderDate;
        private List<OrderDetail> _lineItems;
        private double _count;

        public int OrderID
        {
            get
            {
                return _orderID;
            }
            set
            {
                _orderID = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
            }
        }
        public List<OrderDetail> LineItems 
        {
            get
            {
                return _lineItems;
            }
            set
            {
                _lineItems = value;
            }
        }
        public double Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public Order()
        {
            this._orderID = OrderID;
            this._orderDate = OrderDate;
            this._lineItems = LineItems;
            this._count = Count;
        }
        public Order(int OrderID, DateTime OrderDate, List<OrderDetail> LineItems, int Count)
        {
            _orderID = OrderID;
            _orderDate = OrderDate;
            _lineItems = LineItems;
            _count = Count;
        }
      
        public void AddLineItem(Product p, int q)
        {
            _lineItems.Add(new OrderDetail(p, q));

        }
        public double CalcTotalCharge()
        {

            foreach (OrderDetail item in this._lineItems)
                Count += item.CalcTotalPrice();
            return Count;
        }
        public override string ToString()
        {
            String str = String.Format("{0} \n Ngày lập hóa đơn: {1} \n Tổng tiền thanh toán: {2} ",OrderID, OrderDate,CalcTotalCharge());
            return str;
        }
    }
}
