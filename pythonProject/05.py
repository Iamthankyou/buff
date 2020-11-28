from array import array
from bisect import *

if __name__ == "__main__":
    n = int(input())
    arr = []*n
    arr = list(map(int,input().split()))
    l=[None]*n
    max = 0

    for i in range(n):
        pos = bisect_left(l, arr[i],0,max)
        l[pos] = arr[i]
        if pos+1 > max:
            max = pos+1

    print(max)