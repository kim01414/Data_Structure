using System;

namespace Hanoi
{
    class Program
    {
        static void Hanoi(int A, int B, int C, int n){
            if(n<=0) return;
            Hanoi(A,C,B,n-1);
            Console.WriteLine("Move Disk#{0} from Peg[{1}] to Peg[{2}]",n,A,C);
            Hanoi(B,A,C,n-1);
        }
        static void Main(string[] args)
        {
            Hanoi(1,2,3,3);
        }
    }
}
