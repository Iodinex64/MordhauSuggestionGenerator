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
                Console.WriteLine("Error: " + e + "\n write a number, idiot, that's all you have to do.");
            }
        }
    }
}
