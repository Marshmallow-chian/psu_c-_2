using System;
using System.Collections.Generic;
using System.Linq;

namespace tack2_C
{
    class Program
    {
        static void Main(string[] args)
        {

            Department accounting = new Department("Бухгалтерия", 1, "Жолдышев А.А.");
            Department sales = new Department("Отдел продаж", 2, "Зотов В.А.");
            Department supply = new Department("Отдел закупок", 3, "Мтищев А.Б.");

            List<Worker> workers = new()
            {
                new Worker("Симонов", "Алексей", "Олегович", "32", accounting),
                new Worker("Жуков", "Сергей", "Валерьевич", "28", sales),
                new Worker("Симонова", "Валентина", "Викторовна", "45", supply),
            };


            //Dictionary<string, List<Worker>> dep = new Dictionary<string, List<Worker>>(3); // ...

            var dict = workers.GroupBy(x => x.Department.DepartmentName).ToDictionary(x => x.Key, x => x.ToList());

            foreach (KeyValuePair<string, List<Worker>> keyValue in dict)
            {
                Console.WriteLine(keyValue.Key + " - " + string.Join("\r\n", keyValue.Value));
            }
        }
    }

    class Department
    {
        public string DepartmentName; // название отдела
        public int Number;             // номер отдела
        public string Director;        // руководитель

        public Department(
            string departmentname,
            int number,
            string director)
        { 
            DepartmentName = departmentname;
            Number = number;
            Director = director;
        }
        public override string ToString()
        {
            return $"{DepartmentName} {Number} {Director}";
        }
    } 

    class Worker
    {
        public string Surname;             // фамилия
        public string Name;                // имя
        public string Patronymic;          // отчество
        public string Age;                 // возраст
        public Department Department; // отдел

        public Worker(
            string surname,
            string name,
            string patronic,
            string age,
            Department departament) 
        { 
            Surname = surname;
            Name = name;
            Patronymic = patronic;
            Age = age;
            Department= departament;
        }
        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic} {Age} {Department}";
        }
    }
}
// ctrl rr
// GroupBy ToDictionary