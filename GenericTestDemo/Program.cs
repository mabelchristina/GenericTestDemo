using System;

namespace GenericTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxOfNumber maxOfNumber = new MaxOfNumber();
            Console.WriteLine(maxOfNumber.Max("apple","peach","banana"));
        }
    }
}
