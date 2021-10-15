using System;

namespace tack1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string message = "строка точно больше 6 символов";
                if (message.Length > 6)
                {
                    throw new Exception("Длина строки больше 6 символов");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ОШибка: {e.Message}");
            }
            Console.Read();
        }
    }
}
