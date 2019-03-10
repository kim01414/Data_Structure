using System;

namespace Permutation
{
    class Program
    {
        static void SWAP(char[] str, int i, int j){
            char temp;
            temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }
        static void Sorting(char[] str, int head, int tail){
            for(int i=head ; i<tail-1 ;i++){
                for(int j=i+1 ; j<tail ; j++){
                    if(str[i]>str[j]) SWAP(str,i,j);
                }
            }
        }
        static void Perm(char[] str,int k, int n){
            int i,j;
            if(k==n){
                for (i=0 ; i<n ; i++){
                    Console.Write("{0}",str[i]);
                }
                Console.WriteLine("");
                return;
            }
            Sorting(str,k,n);
            Perm(str,k+1,n);
            for(i=k ; i<n ;i++){
                Sorting(str,k+1,n);
                for(j=k+1 ;j<n ;j++){
                    if(str[k]<str[j]){
                        SWAP(str,k,j);
                        Perm(str,k+1,n);
                        break;
                    }
                }
            }            
        }
        static void Main(string[] args)
        {
           char[] str = {'a','b','c'};
           Perm(str,0,3)
;        }
    }
}
