public class Coin1{
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
    public static int coin1(int n){
        if(n==0) return 0;
        if(n<0) return 9999999;
        return (min(coin1(n-2),coin1(n-6),coin1(n-8))+1);
    }
    public static void main(String args[]){
        int count = coin1(12);
        System.out.printf("Result: %d",count);
    }
}