public class Fibonacci2{
    public static int fibonacci(int n){
        int i;
        int arr[] = new int[n+1];
        arr[0]=0; arr[1] = 1;
        System.out.printf("%d %d ",arr[0],arr[1]);
        for(i=2 ; i<n+1 ; i++){
            arr[i] = arr[i-2] + arr[i-1];
            System.out.printf("%d ",arr[i]);
        }
        return arr[n];
    }
    public static void main(String args[]){
        int num = fibonacci(10);
        System.out.printf("\nResult: %d",num);
    }
}