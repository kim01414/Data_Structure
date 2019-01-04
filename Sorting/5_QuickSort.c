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

int partition(int* array, int start, int end){
    int i,j;
    int pivot = array[end];
    i = start-1;
    for(j=start ; j<end ; j++){
        if(array[j] <= pivot) SWAP(array,++i,j);
    }
    SWAP(array,i+1,end);
    return i+1;
}

void qSort(int* array, int start, int end){
    int mid;
    if(start<end){
        mid = partition(array,start,end);
        qSort(array,start,mid-1);
        qSort(array,mid+1, end);
    }
}

int main()
{
    int array[10] = {8,31,48,73,3,65,20,29,11,15};
    print(array);
    qSort(array, 0, MAX_INDEX);
    print(array);
    return 0;
}