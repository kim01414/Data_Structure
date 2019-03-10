using System;

namespace Factorial
{
    class Program
    {
        static int Factorial(int n){
            if(n==1) return 1;
            return Factorial(n-1) * n;
        }
        static void Main(string[] args)
        {
            int num = Factorial(5);
            Console.WriteLine("Result: {0}",num);
        }
    }
}
