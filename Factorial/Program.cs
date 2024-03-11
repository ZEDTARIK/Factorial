using System;
namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number(Factorial) : ");
            Int32 nbFactorial = Int32.Parse(Console.ReadLine());
            int result = 1;
            for(int i=1; i<=nbFactorial; i++)
            {
                result = result * i;
            }
            Console.WriteLine("\nThe result of Factorial {0}! is : {1} ", nbFactorial, result);

            Console.ReadKey();
        }
    }
}
