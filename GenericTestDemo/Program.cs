using System;

namespace GenericTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxOfNumber maxOfNumber = new MaxOfNumber();
            Console.WriteLine(maxOfNumber.Max(10, 2, 1));
        }
    }
}
