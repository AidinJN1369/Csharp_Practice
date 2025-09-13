using System;


namespace BaseNamespace
{
    public class HanoiTower
    {
        public static void NumberOfMoves(int N)
        {
            int[] Cylinders = { 1, 2, 3 };

            for (int i = 0; i < (N - 1); i++)
            {
                System.Console.WriteLine($"one disc moved from cylinder {Cylinders[0]} to {Cylinders[1]}");
            }
            System.Console.WriteLine($"last disc moved from cylinder {Cylinders[0]} to {Cylinders[2]}");

            for (int i = 0; i < (N - 1); i++)
            {
                System.Console.WriteLine($"one disc moved from cylinder {Cylinders[1]} to {Cylinders[2]}");
            }
        }
    }
}