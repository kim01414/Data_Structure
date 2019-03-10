def f_n(n):
    F = [0,1]
    print(F[0],F[1],end=" ")
    for i in range(2,n+1):
        F.append(F[i-1] + F[i-2])
        print("%d "%(F[i]),end="")
    return F[n]

result = f_n(10)
print("\nResult:",result)