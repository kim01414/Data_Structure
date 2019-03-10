def Comb(n,k):
    if n==k or k==0: return 1
    return ( Comb(n-1,k-1) + Comb(n-1,k))

num = Comb(5,3)
print(num)