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
                int amount = int.Parse(r);
                for (int i = 0; i < amount; i++)
                {
                    BullshitBuilder b = new BullshitBuilder();
                    Console.WriteLine(b.WriteShitpost());
                }

            } catch (Exception e)
            {
                Console.WriteLine("\n write a number, idiot, that's all you have to do.");
                Console.WriteLine("\nPress k to exit.");
                Console.WriteLine("\nAlso here is your shit exception: " + "\n" + e);
                if (Console.ReadKey().Key == ConsoleKey.K)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
