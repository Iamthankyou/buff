from queue import Queue
if __name__ == '__main__':
    a =['dangdungcntt','tienquanutc','quang123','maianh','nguyenminhduc2820']
    for _ in range(int(input())):
        n = int(input())
        Q = Queue()
        for i in [0,1,2,3,4]: Q.put((i,1))
        while n>Q.queue[0][1]:
            x = Q.get()
            n-=x[1]
            Q.put((x[0],x[1]*2))
        print(a[Q.get()[0]])

