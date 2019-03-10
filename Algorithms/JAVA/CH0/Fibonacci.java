public class Fibonacci{
    public static int fibonacci(int n){
        if(n<=1) return n;
        return fibonacci(n-1) + fibonacci(n-2);
    }
    public static void main(String args[]){
        int num;
        num =  fibonacci(5);
        System.out.printf("Result: %d\n",num);
    }
}