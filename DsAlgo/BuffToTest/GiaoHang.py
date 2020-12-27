from queue import PriorityQueue

class elem:
    def __init__(self,x):
        self.x = x
    def __lt__(self,other):
        return self.x>other.x

def solve():
    n = int(input())
    D = []
    for i in range(1000000+1):
        D.append([])
    for _ in range(n):
        a,b = map(int,input().split())
        D[a].append(b)
    Q = PriorityQueue()
    ans = 0

    for i in range(1000000,0,-1):
        for x in D[i]:
            Q.put(elem(x))
        if Q.qsize():
            ans+=Q.get().x
    print(ans)
if __name__ == '__main__':
    solve()

