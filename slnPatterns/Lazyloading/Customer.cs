using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazyloading
{
    public class Customer
    {
        private List<Order> _orders = null;

        public int CustomerId { get; set; }

        public string Name { get; set; }

        public  List<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = LoadOrder();
                }

                return _orders;
            }
        }

        public Customer(int id ,string name)
        {
            CustomerId = id;
            Name = name;
        }

        private List<Order> LoadOrder()
        {
            List<Order> _list = new List<Order>()
            {
                new Order(){OrderId=1,Total=50},
                new Order(){OrderId=2,Total=100},
                new Order(){OrderId=3,Total=150},
                new Order(){OrderId=4,Total=200}
            };

            return _list;
        }
    }
}