using System;

namespace Coin
{
    class Program
    {
        static int Min(params object[] args){
            int min =(int)args[0];
            for(int i=1 ; i<args.Length ; i++){
                if(min>(int)args[i]) min = (int)args[i];
            }
            return min;
        }
        static int Iteration(int n){
            int M;
            int[] N = new int[n+1];
            N[0] = 0;
            for(int i=1 ; i<n+1 ; i++){
                M = N[i-1];
                if(i>=2) M=Min(N[i-2],M);
                if(i>=6) M=Min(N[i-6],M);
                if(i>=8) M=Min(N[i-8],M);
                N[i] = M+1;
            }
            return N[n];
        }
        
        static int Recursive(int n){
            if(n==0) return 0;
            if(n<0) return 999999;
            return (Min(Recursive(n-2),Recursive(n-6),Recursive(n-8))+1);
        }

        static void Main(string[] args)
        {
            int num = Iteration(24);
            int num2 = Recursive(24);
            Console.WriteLine("Iteration: {0}",num);
            Console.WriteLine("Recursive: {0}",num2);
        }
    }
}
