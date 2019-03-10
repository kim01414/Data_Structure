public class Combination1{
    public static void comb1(int arr[], int k, int n){
        if(k>=n){
            for(int i=0; i<n ; i++){
                System.out.printf("%d ",arr[i]);
            }
            System.out.println("");
            return;
        }
        arr[k] = 0;
        comb1(arr,k+1,n);
        arr[k] = 1;
        comb1(arr,k+1,n);
    }

    public static void main(String args[]){
        int arr[] = new int[100];
        comb1(arr,0,3);
    }
}