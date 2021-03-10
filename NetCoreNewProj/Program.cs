using System;

namespace NetCoreNewProj
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            Console.WriteLine("Введите число");
            
            do
            {              
                string answer = Console.ReadLine();
                Console.Clear();
                success = int.TryParse(answer, out int value);
                if (value >= 1 && value <= 10)
                {
                    Console.WriteLine("Ваше число: " + value);
                }
                if(!success)
                {
                    Console.WriteLine("Вы ввели не число");
                }
                
            } while (!success);
            
        }
    }
}
