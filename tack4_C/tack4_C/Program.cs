using System;

namespace tack4_C
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Задание 4.1");
            MetodAdd calc = new MetodAdd();
            calc.Add(5, 6);
            calc.Add(5, 6, 9);

            Console.WriteLine($"Задание 4.2");
            Сonstructor don = new Сonstructor("Дон");
            Сonstructor mike = new Сonstructor("Майк", "Эльф");
            don.Race();
            mike.Race();


        }
    }

    class Сonstructor // Для задания 4.2
    {
        public string name;
        public string race;


        public Сonstructor(string n) { name = n; race = "Человек"; }

        public Сonstructor(string n, string r) { name = n; race = r; }
        public void Race()
        {
            Console.WriteLine($"Имя: {name} Раса: {race}");
        }
    }

    class MetodAdd   // Для задания 4.1
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"{a} + {b} = {result}");
        }
        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"{a} + {b} + {c} = {result}");
        }
    }

    
}
