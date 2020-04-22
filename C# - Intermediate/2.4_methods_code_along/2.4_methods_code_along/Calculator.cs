Snamespace _2._4_methods_code_along
{
    partial class Program
    {
        public class Calculator
        {
            public int Add(params int[] numbers) // to make it easier to pass in values when creating an instance.
            {
                var sum = 0;
                foreach (var number in numbers)
                {
                    sum += number;
                }
                return sum; 
            }
        }
    }
}
