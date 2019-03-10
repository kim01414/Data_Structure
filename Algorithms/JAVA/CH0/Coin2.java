public class Coin2{
    public static int min(int... n){
        int num = 0;
        boolean swi = false;
        for (int s : n){
            if(swi==false) {
                num = s;
                swi = true;
                continue;
            }
            if(num > s) num = s;
        }
        return num;
    }
    
    public static int coin2(int n){
        int i, M;
        int arr[] = new int[n+1];
        arr[0] = 0;
        for(i=1 ; i<n+1 ; i++){
            M = arr[i-1];
            if(i>=2) M = min(M,arr[i-2]);
            if(i>=6) M = min(M,arr[i-6]);
            if(i>=8) M = min(M,arr[i-8]); 
            arr[i] = M+1;
        }
        return arr[n];
    }

    public static void main(String args[]){
        int num = coin2(16);
        System.out.printf("Result: %d",num);
    }
}