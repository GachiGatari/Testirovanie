using System;
using System.Collections.Generic;
using System.Linq;

namespace Testirovanie.Lab4
{
    public class Lab4_Func
    {
        public static int ListValueSearch(List<int> arr, int value)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool CheckNum(string potential_num, int bounds)
        {
            int _;
            if (!Int32.TryParse(potential_num, out _))
            {
                Console.WriteLine("Неправильный ввод! Только числа!");
                return false;
            }

            if (_ < 0 || _ > bounds)
            {
                Console.WriteLine($"Неправильный ввод! Введите число в диапазоне от 0 до {bounds}");
                return false;
            }

            return true;
        }

        public static void MainLoop()
        {
            int bounds = 100;
            while (true)
            {
                int n;
                int x;
                Console.WriteLine("Введите длину массива: ");
                string arr_len = Console.ReadLine();
                if (!CheckNum(arr_len, bounds))
                    continue;

                n = Int32.Parse(arr_len);
                Random _rand = new Random();
                var arr = Enumerable.Range(0, n)
                    .Select(r => _rand.Next(0,100))
                    .ToList();
                Console.Write("Массив: ");
                foreach (var e in arr)
                {
                    Console.Write($"{e}, ");
                }
                Console.WriteLine();
                Console.WriteLine("Введите число для поиска: ");
                string search_num = Console.ReadLine();
                if (!CheckNum(search_num, bounds))
                    continue;
                x = Int32.Parse(search_num);
                int index = ListValueSearch(arr, x);
                if (index != -1)
                {
                    Console.WriteLine($"Индекс {x} = {index}");
                }
                else
                {
                    Console.WriteLine($"{x} нет в массиве");
                }
            }
        }
    }
}