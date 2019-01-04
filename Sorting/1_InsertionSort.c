#include <stdio.h>
#define MAX_INDEX 9

void print(int* array){
    int i;
     for(i=0 ; i<=MAX_INDEX ;i++){
        printf("%d ",array[i]);
    }
    puts("");
}

int main()
{
    int array[10] = {8,31,48,73,3,65,20,29,11,15};
    int i, j;
    int current, target;
    print(array);
    for(i=1 ;i<=MAX_INDEX ; i++){
        current = i-1;
        target = array[i];

        while(current>=0 && target<array[current]){
            array[current+1] = array[current];
            current--;
        }
        array[current+1] = target;
    }
    print(array);
    return 0;
}