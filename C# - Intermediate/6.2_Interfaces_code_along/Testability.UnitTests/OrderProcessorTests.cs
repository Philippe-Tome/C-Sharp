using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _6._2_Interfaces_code_along.ShippingCalculator;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        // Method name_condition_expectation
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(OrderProcessorTests order)
        {
            return 1;
        }
    }
}
