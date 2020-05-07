namespace _6._2_Interfaces_code_along
{
    public class ShippingCalculator
    {
        public interface IShippingCalculator
        {
            float CalculateShipping(OrderProcessor order);
        }

        public class ShippingCalculator : IShippingCalculator
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
