def Comb1(a, k, n):
    if k>=n: 
        for i in range(0,n): print("%d"%(a[i]),end=" ")
        print("")
        return None
    a[k] = 0
    Comb1(a,k+1,n)
    a[k]=1
    Comb1(a,k+1,n)
    
a = [-1]*100
Comb1(a,0,3)
    