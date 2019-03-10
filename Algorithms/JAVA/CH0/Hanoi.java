public class Hanoi{
    public static void hanoi(int A,int B,int C,int n){
        if(n==0) return;
        hanoi(A,C,B,n-1);
        System.out.printf("Move Disk #%d from Peg[%d] to Peg[%d]\n",n,A,C);
        hanoi(B,A,C,n-1);
    }
    public static void main(String args[]){
        hanoi(1,2,3,3);
    }
}