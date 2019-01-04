#include <stdio.h>
#define MAX_INDEX 9

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
    print(array);
    for(i=0 ; i<MAX_INDEX ; i++){
        for(j=i+1 ; j<=MAX_INDEX ; j++){
            if(array[i] > array[j]) SWAP(array,i,j);
        }
    }
    print(array);
    return 0;
}