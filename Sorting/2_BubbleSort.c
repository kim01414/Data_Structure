#include <stdio.h>
#define MAX_INDEX 9
#define TRUE 1
#define FALSE 0

void print(int* array){
    int i;
     for(i=0 ; i<=MAX_INDEX ;i++){
        printf("%d ",array[i]);
    }
    puts("");
}

void SWAP(int* array,int i, int j){
    int temp;
    temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

int main()
{
    int array[10] = {8,31,48,73,3,65,20,29,11,15};
    int i, j;
    int sorted;
    print(array);
    for(i=MAX_INDEX ; i>0 ; i--){
        sorted = TRUE;
        for(j=0 ; j<i ; j++){
            if(array[j]>array[j+1]){
                SWAP(array,j,j+1);
                sorted = FALSE;
            } 
        }
        if(sorted == TRUE){
            print(array);
            break;
        }
    }
    return 0;
}