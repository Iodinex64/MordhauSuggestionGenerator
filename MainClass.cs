using System;

namespace MordhauSuggestionGenerator
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Insightful Veteran Suggestions would you like to generate?");
            string r = Console.ReadLine();
            try
            {
                Random rand = new Random();
                int amount = int.Parse(r);
                for (int i = 0; i < amount; i++)
                {
                    int choose = rand.Next(0, 2);
                    if (choose == 0)
                    {
                        MeleeObject m = new MeleeObject();
                        Console.WriteLine(m.WriteShitpost() + "\n");
                    }
                    else if (choose == 1)
                    {
                        MechanicObject mo = new MechanicObject();
                        Console.WriteLine(mo.WriteShitpost() + "\n");
                    }
                }
                Console.WriteLine("\nPress k to exit.");
                if (Console.ReadKey().Key == ConsoleKey.K)
                {
                    Environment.Exit(0);
                }

            } catch (Exception e)
            {
                Console.WriteLine("\nwrite a number, idiot, that's all you have to do.");
                Console.WriteLine("\nAlso here is your shit exception: " + "\n" + e);
                Console.WriteLine("\nPress k to exit.");
                if (Console.ReadKey().Key == ConsoleKey.K)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
