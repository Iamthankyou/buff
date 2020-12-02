'''
Thang may
'''
from collections import deque
p = []
c = -1
def printPath(u):
    global c
    c=c+1
    if p[u] == -1:
        return
    printPath(p[u])

def main():
    n = int(input())
    k,m = map(int,input().split())
    s,f = map(int,input().split())
    AL = [[] for u in range(n+1)]

    for i in range(1,n+1):
        if (i+k<=n):
            AL[i].append(i+k)
        if (i-m>=1):
            AL[i].append(i-m)

    dist = [1e9 for u in range(n+1)]
    dist[s] = 0
    q = deque()
    q.append(s)

    global p
    p = [-1 for u in range(n+1)]

    while (len(q)>0):
        u = q.popleft()
        for v in AL[u]:
            if (dist[v] == 1e9):
                dist[v] = dist[u] + 1
                p[v] = u
                q.append(v)

    printPath(f)
    if (c==0):
        print(-1)
    else:
        print(c)
main()






