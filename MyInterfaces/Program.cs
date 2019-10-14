using System;
using System.Collections.Generic;

namespace MyInterfaces
{
    class Program
    {
        private static Random rng;
        static void Main(string[] args)
        {
            IHasScore previousScore = null;

            IHasScore[] scoreArray = new IHasScore[10];
            scoreArray[0] = new Player("Boi1", 6);
            scoreArray[1] = new Hotel("Hotel1", "hotel1, man", 8, 3);
            scoreArray[2] = new Player("Boi2", 3);
            scoreArray[3] = new Hotel("´Hotel2", "hotel2, man", 41, 5);
            scoreArray[4] = new Player("Boi3", 4);
            scoreArray[5] = new Hotel("Hotel3", "hotel3, man", 35, 4);
            scoreArray[6] = new Player("Boi4", 25);
            scoreArray[7] = new Hotel("Hotel4", "hotel4, man", 14, 3);
            scoreArray[8] = new Player("Boi5", 5);
            scoreArray[9] = new Hotel("Hotel5", "hotel5, man", 7, 2);

            foreach (IHasScore s in scoreArray)
            {
                Console.WriteLine($"{s}'s score is {s.Score}");
                if (previousScore != null)
                {
                    Console.WriteLine($"Equals to last? Answer: " +
                        $"{s.Equals(previousScore)}");
                }
                previousScore = s;
            }
        }
    }
}
