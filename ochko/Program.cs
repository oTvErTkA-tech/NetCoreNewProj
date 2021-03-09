using System;

namespace ochko
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPalyerContinue = true;
            bool isComputerContinue = true;
            Random random = new Random();

            do
            {
                Console.WriteLine("Будешь тянуть карту, y/n");
                string answer = Console.ReadLine();
                
                if (answer == "y")
                {
                    Console.WriteLine("Вы тянете карту");
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Вы пасуете");
                    isPalyerContinue = false;
                }

                int decisionNumber = 0;

                if (isComputerContinue)
                {
                    decisionNumber = random.Next(0, 2);
                }

                if (decisionNumber == 0)
                {
                    Console.WriteLine("Компьютер тянете карту");
                }
                else if (decisionNumber == 1)
                {
                    Console.WriteLine("Компьютер пасуете");
                    isComputerContinue = false;
                }

            } while (isPalyerContinue || isComputerContinue);
            
        }
    }
}
