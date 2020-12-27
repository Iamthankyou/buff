from queue import PriorityQueue

def solve():
    arr = list(map(int,input().split()))
    ans = 0
    pq = PriorityQueue()

    for i in arr:
        pq.put(i)

    while pq.qsize()>1:
        s = pq.get() + pq.get()
        ans+=s
        pq.put(s)

    print(ans)

if __name__ == '__main__':
    solve()