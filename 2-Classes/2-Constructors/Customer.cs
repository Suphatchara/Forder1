using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Order;

        public Customer()
        {
            Order = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}





























