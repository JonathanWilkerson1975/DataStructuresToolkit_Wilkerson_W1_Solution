namespace DataStructuresToolkit
{
    public class ComplexityTester
    {
        // O(1) - Constant time example
        public int ConstantTimeMethod(int x)
        {
            return x * x; // Just square the number
        }

        // O(n) - Linear time example
        public int LinearTimeMethod(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // O(n^2) - Quadratic time example
        public int QuadraticTimeMethod(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum += numbers[i] * numbers[j];
                }
            }
            return sum;
        }
    }
}
