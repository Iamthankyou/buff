from queue import PriorityQueue
def solve():
    n = int(input())
    V = list(map(int,input().split()))
    T = list(map(int,input().split()))
    pq = PriorityQueue()
    s = 0

    for v,t in zip(V,T):
        pq.put(s+v)
        ans = 0
        while pq.qsize() and pq.queue[0]-s<=t:
            ans+=pq.get()-s
        ans+=pq.qsize()*t
        s = s+t if pq.qsize() else 0
        print(ans,end=' ')

if __name__ == '__main__':
    solve()