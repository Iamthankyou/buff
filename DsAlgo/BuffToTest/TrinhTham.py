from collections import deque

def solve():
    n,k = map(int,input().split())
    arr = list(map(int,input().split()))
    dq = deque([])

    for i,x in enumerate(arr):
        if i<k-1:
            while len(dq)>0 and dq[-1][0]<x:
                dq.pop()
            dq.append((x,i))
        else:
            while len(dq)>0 and dq[-1][0]<x:
                dq.pop()
            dq.append((x,i))
            while i-dq[0][1]+1>k:
                dq.popleft()
            print(dq[0][0],end=' ')
if __name__ == '__main__':
    solve()