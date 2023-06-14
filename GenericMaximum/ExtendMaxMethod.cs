using System;

namespace GenericMaximum
{
    internal class ExtendMaxMethod
    {
        static void Main(string[] args)
        {
            int maxInt = FindMaximum(10, 5, 8, 15, 3); // Test Case 1
            Console.WriteLine("Max Number: " + maxInt);

            float maxFloat = FindMaximum(3.2f, 12.9f, 6.7f, 8.4f); // Test Case 2
            Console.WriteLine("Max Number: " + maxFloat);

            string maxString = FindMaximum("Apple", "Peach", "Banana", "Mango"); // Test Case 3
            Console.WriteLine("Max String: " + maxString);
        }

        static T FindMaximum<T>(params T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("At least one value must be provided.");

            T max = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                    max = values[i];
            }

            return max;
        }
    }
}
