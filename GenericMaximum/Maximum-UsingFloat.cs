using System;

namespace GenericMaximum
{
    internal class MaximumUsingFloat
    {
        static void Main(string[] args)
        {
            float maxFloat = FindMaximum(10.5f, 5.3f, 8.7f); // Test Case 1
            Console.WriteLine("Max Number: " + maxFloat);

            maxFloat = FindMaximum(3.2f, 12.9f, 6.7f); // Test Case 2
            Console.WriteLine("Max Number: " + maxFloat);

            maxFloat = FindMaximum(7.1f, 9.8f, 15.2f); // Test Case 3
            Console.WriteLine("Max Number: " + maxFloat);
        }

        static float FindMaximum(float num1, float num2, float num3)
        {
            float max = num1;

            if (num2 > max)
                max = num2;

            if (num3 > max)
                max = num3;

            return max;
        }
    }
}
