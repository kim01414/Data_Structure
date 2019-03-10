def Coin1(n):
    if n==0: return 0
    if n<0: return 999999
    return ( min(Coin1(n-1),Coin1(n-2),Coin1(n-6),Coin1(n-8))+1)

count = Coin1(12)
print(count)

#시간이 많이 소요된다!!!
#Coin1: 999 step이상
#Coin2: 100 step미만