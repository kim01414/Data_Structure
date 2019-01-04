#include <stdio.h>
#define MAX_INDEX 9

void print(int* array){
    int i;
     for(i=0 ; i<=MAX_INDEX ;i++){
        printf("%d ",array[i]);
    }
    puts("");
}

void Merge(int* array, int start, int mid, int end){
    int temp[10];
    int i=start, j=mid+1, t=0;

    while(i<=mid && j<=end){
        if(array[i] <= array[j]) temp[t++] = array[i++];
        else temp[t++] = array[j++];
    }

    while(i<=mid) temp[t++] = array[i++];
    while(j<=end) temp[t++] = array[j++];

    i=start; t=0;
    while(i<=end) array[i++] = temp[t++];
}

void MergeSort(int *array, int start, int end){
    int mid;
    if(start <  end){
        mid = (start+end) / 2;
        MergeSort(array,start,mid);
        MergeSort(array,mid+1,end);
        Merge(array,start,mid,end);
    }
}

int main()
{
    int array[10] = {8,31,48,73,3,65,20,29,11,15};
    int i, j;
    print(array);
    MergeSort(array,0,MAX_INDEX);
    print(array);
    return 0;
}