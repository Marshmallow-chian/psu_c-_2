using System;
using System.Collections.Generic;
using static System.Console;
namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Temp temp = new Temp(1, 6);
            Temp temp1 = temp;
            temp1.Apple = 333;
            int i = 1;
            int ii = 1;
            Dictionary<int, string> dict = new();
            Dictionary<Temp, string> dict1 = new();
            dict.Add(i, "stroka");
            dict1.Add(temp, "stroka1");
            WriteLine($"значимый {dict.TryGetValue(ii, out string p)} ссылочный {dict1.TryGetValue(temp1, out string p1)}");


            ReadKey();

        }
    }

    class Temp
    {
        public static int Banan;
        public int Apple;

        public Temp()
        {

        }

        public Temp(int apple, int banan)
        {
            Apple = apple;
            Banan = banan;
        }
    }
}
