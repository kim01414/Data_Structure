public class Combination2{
    public static void comb2(int arr[], int k, int n){
        if(k<0){
            for(int i=0; i<n ; i++){
                System.out.printf("%d ",arr[i]);
            }
            System.out.println("");
            return;
        }
        arr[k] = 0;
        comb2(arr,k-1,n);
        arr[k] = 1;
        comb2(arr,k-1,n);
    }

    public static void main(String args[]){
        int arr[] = new int[100];
        comb2(arr,2,3);
    }
}