using System;



namespace RunNamespace
{
    public class RunClass()
    {
        public static void Main()
        {

            System.Console.WriteLine("enter first number : ");
            double Num1 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("enter one of (+ , - , * , /) :");
            char Func = Convert.ToChar(Console.ReadLine());
            System.Console.WriteLine("enter second number : ");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            double Result;


            switch (Func)
            {
                case '+':
                    Result = SimpleCalculator.SumFunc(Num1, Num2);
                    System.Console.WriteLine($"the result is : {Result}");
                    break;
                case '-':
                    Result = SimpleCalculator.SubFunc(Num1, Num2);
                    System.Console.WriteLine($"the result is : {Result}");
                    break;
                case '*':
                    Result = SimpleCalculator.MultFunc(Num1, Num2);
                    System.Console.WriteLine($"the result is : {Result}");
                    break;
                case '/':
                    Result = SimpleCalculator.DivFunc(Num1, Num2);
                    System.Console.WriteLine($"the result is : {Result}");
                    break;
            }








        }
    }

}
