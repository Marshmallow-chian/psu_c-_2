using System;

namespace tack3_C
{
    interface IСalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    class Program
    {

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int a = 5;
            int b = 6;
            Console.WriteLine(calc.Add(a, b));
            Console.WriteLine(calc.Subtract(a, b));

        }
    }

    class Calculator : IСalculator
    {
        private int a;
        private int memory;

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}