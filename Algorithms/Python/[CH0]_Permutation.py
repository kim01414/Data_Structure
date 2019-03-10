def SWAP(target, i,j):
    temp = target[i]
    target[i] = target[j]
    target[j] = temp

def sorting(target,k,n):
    for i in range(k,n-1):
        for j in range(i+1,n):
            if target[i] > target[j]:
                SWAP(target,i,j)

def perm(target, k, n):
    if k==n: 
        print(target)
        return None
    sorting(target,k,n)
    perm(target,k+1,n)
    for _ in range(1,n):
        sorting(target,k+1,n)
        for j in range(k,n):
            if target[k] < target[j]:
                SWAP(target,k,j)
                perm(target,k+1,n)
                break

text = ['a','b','b','c','c','c']
perm(text,0,6)
