using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazyloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Miguel");

            foreach (Order order in customer1.Orders)
            {
                Console.WriteLine("OederID: " + order.OrderId + "total: " + order.Total);
            }

        }
    }
}
