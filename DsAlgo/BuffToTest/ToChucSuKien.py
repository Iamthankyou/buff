def solve():
    n = int(input())
    E = []

    for _ in range(n):
        start,finish = map(int,input().split())
        E.append((start,finish))

    E.sort(key = lambda x:x[1])

    time = 0
    ans = 0

    for i in E:
        if i[0] > time:
            ans+=1
            time = i[1]

    print(ans)
if __name__ == '__main__':
    solve()