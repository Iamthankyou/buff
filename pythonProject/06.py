from array import array
from collections import deque

if __name__ == "__main__":
    n,k = map(int,input().split())
    arr = []*n
    arr = list(map(int,input().split()))

    dq = deque

    for i in range(k):
        while (dq.count>0 and dq.index(-1)<=arr[i]):
            dq.pop()
        dq.insert(arr[i])




