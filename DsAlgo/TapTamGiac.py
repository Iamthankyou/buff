import collections
n = int(input())
arr = list(map(int,input().split()))
res = 0

arr.sort()
dq = collections.deque()

for i in arr:
    if (len(dq)>1):
        dq.append(i)
        if (dq[0]+dq[1]<=i):
            dq.popleft()
    else:
        dq.append(i)

    res = max(res,len(dq))

if (res>2):
    print(res)
else:
    print('Khong the tao ra day thoa man')



