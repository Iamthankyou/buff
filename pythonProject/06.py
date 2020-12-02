from array import array
from collections import deque

if __name__ == "__main__":
    n,k = map(int,input().split())
    arr = list(map(int,input().split()))

    dq = deque()

    for i in range(k-1):
        while (len(dq)>0 and arr[dq[-1]]<=arr[i]):
            dq.pop()
        dq.append(i)

    for i in range(k-1,n):
        while (len(dq)>0 and arr[dq[-1]]<=arr[i]):
            dq.pop()
        dq.append(i)
        while (i-dq[0]>=k):
            dq.popleft()
        print(arr[dq[0]], end=" ")






