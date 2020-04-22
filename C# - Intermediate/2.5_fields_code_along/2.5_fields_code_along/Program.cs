using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_fields_code_along
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
