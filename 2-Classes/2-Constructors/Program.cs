using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "khing");

            var order = new Order();

            customer.Order.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}






























































                                                                                                                                                                                                                                      






























































