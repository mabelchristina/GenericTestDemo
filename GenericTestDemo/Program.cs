using System;
using static GenericTestDemo.MaxOfNumber;

namespace GenericTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 4, 11, 7 };
            float[] floatArray = { 2.5f, 2.2f, 2.8f };
            string[] stringArray = { "Apple", "Peach", "Banana" };
            FindMaximum<int> findMaximumint = new FindMaximum<int>(intArray);
            FindMaximum<float> findMaximumfloat = new FindMaximum<float>(floatArray);
            FindMaximum<string> findMaximumstring = new FindMaximum<string>(stringArray);
            Console.WriteLine("largest Integer  : " + findMaximumint.FindMax());
            Console.WriteLine("largest Float  : " + findMaximumfloat.FindMax());
            Console.WriteLine("largest String : " + findMaximumstring.FindMax());
            findMaximumint.PrintMax();
            findMaximumfloat.PrintMax();
            findMaximumstring.PrintMax();
        }
    }
}
