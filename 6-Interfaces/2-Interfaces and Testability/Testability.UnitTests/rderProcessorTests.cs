using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATIONB
        [TestMethod]

        [ExpectedException(typeof(Inv)]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            {
                shipment = new Shipment()

            };

            orderProcessor.Process(order);

        }
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);


        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CaculateShipping(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
