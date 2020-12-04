from queue import Queue

if __name__ == '__main__':
    arr = ['dangdungcntt', 'tienquanutc', 'quang123', 'maianh', 'nguyenminhduc2820']
    for _ in range(int(input())):
        n = int(input())
        queue = Queue()
        for i in range(0,5):
            print(i)
            queue.put((i, 1))

        while n > queue.queue[0][1]:
            p = queue.get()
            n -= p[1]
            queue.put((p[0], p[1] * 2))

        print(arr[queue.get()[0]])
