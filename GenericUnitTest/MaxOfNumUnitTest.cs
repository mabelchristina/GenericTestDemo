using GenericTestDemo;
using NUnit.Framework;
using static GenericTestDemo.MaxOfNumber;

namespace GenericUnitTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] intArray = { 4, 11, 7 };
            int max = 11;
            FindMaximum<int> findMaximum = new FindMaximum<int>(intArray);
            int res = findMaximum.FindMax();
            Assert.AreEqual(res, max);
        }
        public void Test2()
        {
            float[] floatArray = { 2.5f, 2.2f, 2.8f };
            float max = 2.8f;
            FindMaximum<float> findMaximum = new FindMaximum<float>(floatArray);
            float res = findMaximum.FindMax();
            Assert.AreEqual(res, max);
        }
        public void Test3()
        {
            string[] stringArray = { "Apple", "Peach", "Banana" };
            string max = "Peach";
            FindMaximum<string> findMaximum = new FindMaximum<string>(stringArray);
            string res = findMaximum.FindMax();
            Assert.AreEqual(res, max);
        }
    }
}