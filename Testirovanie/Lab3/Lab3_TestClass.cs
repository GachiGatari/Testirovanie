using System;
using System.Linq;
using NUnit.Framework;

namespace Testirovanie.Lab3
{
    [TestFixture]
    public class Lab3_TestClass
    {
        [TestCase(1, 1)]
        [TestCase(5,120)]
        public void TestFactorial(int num, int factorial)
        {
            Assert.AreEqual(Lab3_Func.Factorial(num), factorial);
        }
        
        [TestCase(1, 1)]
        [TestCase(5,2)]
        public void TestPower(int num, int power)
        {
            Assert.AreEqual(Lab3_Func.Power(num, power), Math.Pow(num, power));
        }
        
        
        [TestCase(10)]
        [TestCase(-10)]
        public void TestAbs(int num)
        {
            Assert.AreEqual(Lab3_Func.Abs(num), Math.Abs(num));
        }
        
        [TestCase(0.5)]
        [TestCase(-0.5)]
        public void TestSin(double x)
        {
            Assert.Less(Math.Abs(Lab3_Func.Sin(x) - Math.Sin(x)), 1e-10 * 0.5);
        }
        
        
        [TestCase(0.5)]
        [TestCase(12)]
        public void TestCos(double x)
        {
            Assert.Less(Math.Abs(Lab3_Func.Cos(x) - Math.Cos(x)), 1e-10 * 0.5);
        }
        
        [TestCase(0.5)]
        [TestCase(0.6)]
        public void TestLn(double x)
        {
            Assert.Less(Math.Abs(Lab3_Func.Ln(x) - Math.Log(x)), 1e-10);
        }
        
        [TestCase(0.5, -0.6082938784300553)]
        [TestCase(-0.5, -0.9577488571996811)]
        public void TestMyFunc(double x, double result)
        {
            Assert.AreEqual(Lab3_Func.MyFunc(x), result);
        }
    }
}