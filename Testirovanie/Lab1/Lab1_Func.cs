using System;
using System.Collections.Generic;
using System.Linq;

namespace Testirovanie.Lab1
{
    public static class Lab1_Func
    {
        public static int[] SortFunc(int[] arr)
        {
            arr =  arr.OrderBy(x => x).ToArray();
            return arr;
        }

        public static bool IsPalindromFunc(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return str == new string(charArray);
        }
        
        public static int FactorialFunc(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i; 
            }
            return fact;
        }

        public static int FibFunc(int num)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 2; i < num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

        public static float PowFloat(float x, float y)
        {
            return (float)Math.Pow(x, y);
        }

        public static bool IsProstNum(int num)
        {
            for(int i = 2; i< num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}