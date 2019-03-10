def Comb2(a, k, n):
    if k<0: 
        for i in range(0,n): print("%d"%(a[i]),end=" ")
        print("")
        return None
    a[k] = 0
    Comb2(a,k-1,n)
    a[k]=1
    Comb2(a,k-1,n)
    
a = [-1]*100
Comb2(a,2,3)
    