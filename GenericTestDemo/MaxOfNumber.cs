using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTestDemo
{
    public class MaxOfNumber
    {
        public float Max(float a, float b, float c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            if (b > c && b > c)
            {
                return b;
            }
            return c;
        }
    }
}
