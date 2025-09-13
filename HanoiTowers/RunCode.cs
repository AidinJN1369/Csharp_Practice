using System;
using BaseNamespace;


namespace RunNamespace
{
    class RunClass
    {
        static void Main()
        {
            System.Console.WriteLine("enter number of discs u wanna play with : ");
            int InputNumber = int.Parse(Console.ReadLine());

            HanoiTower.NumberOfMoves(InputNumber);
        }
    }
}