
def solve():
    n = int(input())
    board = [[] for _ in range(n)]
    boardX = [0,0,0]

    for i in range(3):
        boardX[i] = [[[]for _ in range(n)] for _ in range(n)]

    changeX = [0,0,0]

    for x in range(n):
        board[x] = input()
        for y in range(n):
            for i in range(3):
                boardX[i][x][y] = board[x][y]

    for x in range(n):
        for y in range(n):
            if board[x][y]=='.':
                continue
            changeX[(x + y) % 3] += 1
            boardX[(x + y) % 3][x][y] = 'O'

    ans = [[]]

    if changeX[0]<=changeX[1] and changeX[0]<=changeX[2]:
        ans = boardX[0]
    elif changeX[1]<=changeX[2]:
        ans = boardX[1]
    else:
        ans = boardX[2]

    for x in range(n):
        for y in range(n):
            print(ans[x][y],end='')
        print()

if __name__ == '__main__':
    t = int(input())
    for _ in range(t):
        solve()