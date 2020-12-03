from functools import lru_cache
import sys

sys.setrecursionlimit(100000)


MAX_N = 100
MAX_W = 100
N = 0
V = [0] * MAX_N
W = [0] * MAX_N

@lru_cache(maxsize=None)
def dp(id,remainWeight):
    if remainWeight==0 or id==N:
        return 0
    if W[id]>remainWeight:
        return dp(id+1,remainWeight)
    return max(dp(id+1,remainWeight),V[id]+dp(id+1,remainWeight-W[id]))

if __name__ == '__main__':
    N = int(input())
    for i in range(N):
        W[i],V[i] = map(int,input().split())
    T = int(input())
    for _ in range(T):
        w = int(input())
        print(dp(0,w))