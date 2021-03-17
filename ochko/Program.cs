using System;

namespace ochko
{
    class Program
    {       
        static void Main(string[] args)
        {
            Printer.Print("Test value");
            Game.PrintInfo("test");




            //int[] cards = new int[]
            //{
            //    2,3,4,5,6,7,8,9,10,10,10,10,11,
            //    2,3,4,5,6,7,8,9,10,10,10,10,11,
            //    2,3,4,5,6,7,8,9,10,10,10,10,11,
            //    2,3,4,5,6,7,8,9,10,10,10,10,11
            //};

            //cards = Shaffle(cards);
            //cards = Shaffle(cards);
            //cards = Shaffle(cards);            

            //bool isPlayerContinue = true;
            //bool isComputerContinue = true;
            //int index = 0;
            //Random random = new Random();

            //do
            //{
            //    Console.WriteLine("Будешь тянуть карту, y/n");
            //    string answer = Console.ReadLine();

            //    isPlayerContinue = PlayersChoice(isPlayerContinue, answer);
            //    if (isPlayerContinue == true)
            //    {
            //        GiveCard(index,cards);
            //        index++;
            //    }
            //    isComputerContinue = ComputerChoice(isComputerContinue, random);
            //    if (isComputerContinue == true)
            //    {
            //        GiveCard(index,cards);
            //        index++;
            //    }
            //} while (isPlayerContinue || isComputerContinue);

        }

        private static int[] Shaffle(int[] cards)
        {
            int[] result = new int[cards.Length];
            Random random = new Random();

            for (int i = 0; i < cards.Length; i++)
            {
                int index = random.Next(0, cards.Length);

                if (cards[index] == 0)
                {
                    i--;
                    continue;
                }
                else
                {
                    result[i] = cards[index];

                }
                cards[index] = 0;
            }

            return result;
        }

        private static bool ComputerChoice(bool isComputerContinue, Random random)
        {
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

            return isComputerContinue;
        }

        private static bool PlayersChoice(bool isPlayerContinue, string answer)
        {
            if (answer == "y")
            {
                Console.WriteLine("Вы тянете карту");
            }
            else if (answer == "n")
            {
                Console.WriteLine("Вы пасуете");
                isPlayerContinue = false;
            }

            return isPlayerContinue;
        }

        private static int GiveCard(int index, int[] cards)
        {
            int card = cards[index];
            Console.WriteLine(card);
            return card;
        }
    }
}
