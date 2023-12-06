using System;
using System.Linq;
using NUnit.Framework;

namespace Testirovanie.Lab1
{
    [TestFixture]
    public class Lab1_TestClass
    {
        [TestCase(new int[]{1,5,7,2})]
        [TestCase(new int[]{1,5,6,2,7})]
        public void TestSortFunc(int[] arr)
        {
            CollectionAssert.AreEqual((from element in arr orderby element ascending select element)
                .ToArray(), Lab1_Func.SortFunc(arr));
        }
        
        [TestCase("lol")]
        [TestCase("шалаш")]
        public void TestIsPalindormFunc(string str)
        {
            Assert.That(Lab1_Func.IsPalindromFunc(str), Is.True);
        }
        
        [TestCase(1, 1)]
        [TestCase(5,120)]
        public void TestFactorialFunc(int num, int factorial)
        {
            Assert.AreEqual(Lab1_Func.FactorialFunc(num), factorial);
        }
        
        [TestCase(11, 55)]
        [TestCase(0,0)]
        public void TestFibFunc(int index, int num)
        {
            Assert.AreEqual(Lab1_Func.FibFunc(index), num);
        }
        
        [TestCase((float) 0.1, (float) 0.2, (float) 0.630957344)]
        [TestCase((float) 0.1, (float) 0.3, (float) 0.501187234)]
        public void TestPowFloat(float x, float y, float actualPow)
        {
            Assert.Less(Math.Abs(Lab1_Func.PowFloat(x,y) - actualPow), 1e-17 * 0.5);
        }
        
        [TestCase(5,true)]
        [TestCase(10, false)]
        public void TestIsProstNum(int num, bool answer)
        {
            Assert.AreEqual(Lab1_Func.IsProstNum(num), answer);
        }
    }
}