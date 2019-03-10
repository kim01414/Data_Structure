using System;

namespace nCk
{
    class Program
    {
        static int Comb(int n,int k){
            if(n==k || k==0) return 1;
            return Comb(n-1,k-1)+Comb(n-1,k);
        }
        static void Main(string[] args)
        {
            int num = Comb(10,2);
            Console.WriteLine("{0}",num);
        }
    }
}
