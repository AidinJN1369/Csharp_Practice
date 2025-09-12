using System;



namespace BaseNamespace
{
    public class RandomNumberGenerator
    {
        public static int RandomNumberMaker(int Minimum , int Maximum)
        {

            Random RandomNumber = new Random();
            return RandomNumber.Next(Minimum , Maximum);
        }
        
        
    }

}
