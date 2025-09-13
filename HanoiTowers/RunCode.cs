using System;
using BaseNamespace;


namespace RunNamespace
{
    class RunClass
    {
        static void Main()
        {
            System.Console.WriteLine("enter the number of discs you wannt to play with : ");
            int InputNumber = int.Parse(Console.ReadLine());

            HanoiTower.NumberOfMoves(InputNumber);
        }
    }

}
