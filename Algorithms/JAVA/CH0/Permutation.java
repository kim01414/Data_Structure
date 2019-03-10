public class Permutation{
    public static void SWAP(char arr[], int a, int b){
        char temp;
        temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    public static void Sorting(char arr[],int k, int n){
        int i,j;
        for(i=k ; i<n-1 ; i++){
            for(j=i+1 ; j<n ; j++){
                if(arr[i]>arr[j]) SWAP(arr,i,j);
            }
        }
    }
    public static void perm(char arr[],int k, int n){
        int i,j;
        if(k>=n){
            System.out.println(arr);
            return;
        }
        Sorting(arr,k,n);
        perm(arr,k+1,n);
        for(i=1 ; i<n ; i++){
            Sorting(arr,k+1,n);
            for(j=k+1 ; j<n ; j++){
                if(arr[k]<arr[j]){
                    SWAP(arr,k,j);
                    perm(arr,k+1,n);
                    break;
                } 
            }
            
        }
    }
    public static void main(String args[]){
        char arr[] = {'a','b','e','b','c','c'};//{'a','a','b','c','c','c','d','d','d','e'};
        perm(arr,0,6);
    }
}