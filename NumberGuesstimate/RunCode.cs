using System;




namespace RunNamespace
{
    
    using BaseNamespace;
    
    public class RunClass
    {

        public static void Main()
        {
            System.Console.WriteLine("enter a whole number between 1 and 99 : ");
            int SelectedNumber = RandomNumberGenerator.RandomNumberMaker(1, 100);
            int count = 0;

            while (true)
            {
                int InputNumber = int.Parse(Console.ReadLine());

                if (InputNumber < SelectedNumber)
                {
                    System.Console.WriteLine("its lower, try again");
                    count++;
                    continue;
                }
                if (InputNumber > SelectedNumber)
                {
                    System.Console.WriteLine("its high, try again");
                    count++;
                    continue;
                }
                if (InputNumber == SelectedNumber)
                {
                    count++;
                    System.Console.WriteLine($"bravo ! u guessed right. it took you {count} times.");
                    break;
                }
            }

            
            
        }
    }
    

}

