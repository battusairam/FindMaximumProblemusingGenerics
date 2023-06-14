using System;

namespace GenericMaximum
{
    internal class MaximumString
    {
        static void Main(string[] args)
        {
            string maxString = FindMaximum("Apple", "Peach", "Banana"); // Test Case 1
            Console.WriteLine("Max String: " + maxString);

            maxString = FindMaximum("Hello", "World", "OpenAI"); // Test Case 2
            Console.WriteLine("Max String: " + maxString);

            maxString = FindMaximum("Programming", "is", "fun"); // Test Case 3
            Console.WriteLine("Max String: " + maxString);
        }

        static string FindMaximum(string str1, string str2, string str3)
        {
            string max = str1;

            if (string.Compare(str2, max) > 0)
                max = str2;

            if (string.Compare(str3, max) > 0)
                max = str3;

            return max;
        }
    }
}
