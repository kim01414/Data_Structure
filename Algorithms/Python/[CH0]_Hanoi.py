counter = [3,0,0]

def T_H(A,B,C,n): #출발지 / 경유지 / 목적지 / Disk갯수
    if(n<=0): return None
    T_H(A,C,B,n-1) # Step #1
    print("Move Disk #%d from %d to %d"%(n,A,C)) # Step #2
    counter[A-1]-=1
    counter[C-1]+=1
    print("Discs Count: %d %d %d\n"%(counter[0],counter[1],counter[2]))
    T_H(B,A,C,n-1) # Step #3


print("Discs Count: %d %d %d\n"%(counter[0],counter[1],counter[2]))
T_H(1,2,3,3)

#하노이의 탑 Key
#1. Peg A에서 n-1개의 원판을 Peg C를 이용하여 Peg B로 이동
#2. Peg A에서 남은 1개의 원판을 Peg C으로 이동
#3. Peg B에서 n-1개의 원판을 Peg A를 이용하여 Peg C로 이동

#헷갈리는 이유
#1. T_H(A,C,B,n-1)이라고 해서 무조건 Peg A==>Peg C가 아님을 명심할 것
#   재귀함수 단계에 따라 Peg C==>Peg A 혹은 Peg B==>Peg C, Peg C==>Peg B 등 일수 있음