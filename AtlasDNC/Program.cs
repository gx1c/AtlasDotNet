using System;

namespace AtlasDNC
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int number2 = 4;
            Console.WriteLine("Initiating...");

            int smth = addition(number2, number);
            Console.WriteLine(smth);
            loopdyloop(number);
        }

        static void loopdyloop(int num)
        {
            Console.WriteLine("Atlas says HI!");
            return;
        }

        static int addition(int a, int b)
        {
            int result = a + b;
            return result;
        }


    }


}
