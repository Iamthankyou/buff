n = int(input())
arr = list(map(int,input().split()))
L = [int]*n
R = [int]*n
res = 0

L[0] = arr[0]
R[n-1] = arr[-1]


for i in range(1,n):
    L[i] = max(L[i-1],arr[i])

for i in range(n-2,-1,-1):
    R[i] = max(R[i+1],arr[i])

for i in range(1,n-1):
    if (arr[i] < min(L[i-1],R[i+1])):
        res+= min(L[i-1],R[i+1]) - arr[i]

print(res)