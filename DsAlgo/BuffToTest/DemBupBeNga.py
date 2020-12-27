from queue import Queue

def solve():
    n,k = map(int,input().split())
    a = list(map(int,input().split()))
    a.sort(reverse=True)

    q = Queue()

    for i in a:
        if q.qsize()>0 and i+k<=q.queue[0]:
            q.get()
        q.put(i)

    print(q.qsize())

if __name__ == '__main__':
    solve()