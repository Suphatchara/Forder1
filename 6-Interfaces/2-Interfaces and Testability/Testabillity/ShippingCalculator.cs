using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testabillity
{
    class ShippingCalculator
    {
        public interface IShippingCalculator
        {
            float CalculateShipping(Order order);
        }
        public float CalculateShipping(Order order)
        {
            if (Order.TotalPrice < 30f)
                return Order.TotalPrice * 0.1f;

            return 0;

        }
        
    }
}
