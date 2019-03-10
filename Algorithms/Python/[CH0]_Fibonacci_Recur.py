def f_n(n):
    if n<=1: return n
    return f_n(n-1) + f_n(n-2)

result = f_n(10)
print(result)