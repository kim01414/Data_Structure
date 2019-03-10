using System;

namespace Combination
{
    class Program
    {
        static void Comb1(int[] target, int k, int n){
            if(k>=n){
                Console.WriteLine("{0} {1} {2}",target[0],target[1],target[2]);
                return;
            }
            target[k] = 0;
            Comb1(target,k+1,n);
            target[k] = 1;
            Comb1(target,k+1,n);
        }
        static void Comb2(int[] target, int k , int n){
            if(k<0){
                Console.WriteLine("{0} {1} {2}",target[0],target[1],target[2]);
                return;
            }
            target[k] = 0;
            Comb2(target,k-1,n);
            target[k] = 1;
            Comb2(target,k-1,n);
        }
        static void Main(string[] args)
        {
            int[] arr  = new int[3];
            int[] arr2 = new int[3];
            Comb1(arr,0,3);
            Console.WriteLine("");
            Comb2(arr2,2,3);
        }
    }
}
