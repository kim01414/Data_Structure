using System;

namespace Fibonacci
{
    class Program
    {
        static int Iteration(int n){
            int i;
            int[] arr = new int[n+1];
            arr[0] = 0; arr[1] = 1;
            for(i=2 ; i<n+1 ; i++){
                arr[i] = arr[i-2] + arr[i-1];
            }
            return arr[n];
        }
        static int Recursive(int n){
            if(n<=1) return n;
            return Recursive(n-2) + Recursive(n-1);
        }

        static void Main(string[] args)
        {
            int num1,num2;
            num1 = Iteration(10);
            num2 = Recursive(10);
            Console.WriteLine("Iteration: {0}",num1);
            Console.WriteLine("Recursive: {0}",num2);
        }
    }
}
