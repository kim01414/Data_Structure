public class Combination{
    public static int comb(int n, int k){
        if(n==k || k==0) return 1;
        return ( comb(n-1,k-1) + comb(n-1,k) );
    }
    public static void main(String args[]){
        int num = comb(5,3);
        System.out.printf("Result: %d",num);
    }
}