def Coin2(n):
    N = []
    N.append(0)
    for i in range(1,n+1):
        M = N[i-1]
        if i>=2: M = min(M,N[i-2])
        if i>=6: M = min(M,N[i-6])
        if i>=8: M = min(M,N[i-8])
        N.append(M+1)
    return N[n]

num = Coin2(16)
print(num)
