
def solve():
    n = int(f.readline())
    board = [[] for _ in range(n)]
    boardX = [0,0,0]
    boardO = [0,0,0]

    for i in range(3):
        boardX[i] = [[[]for _ in range(n)] for _ in range(n)]
        boardO[i] = [[[]for _ in range(n)] for _ in range(n)]

    changeX = [0,0,0]
    changeO = [0,0,0]

    for x in range(n):
        board[x] = f.readline()
        for y in range(n):
            for i in range(3):
                boardX[i][x][y] = board[x][y]
                boardO[i][x][y] = board[x][y]
    k = 0

    for x in range(n):
        for y in range(n):
            if board[x][y]=='.':
                continue
            if board[x][y]=='X':
                changeO[(x+y)%3]+=1
                boardO[(x+y)%3][x][y]='O'
            else:
                changeX[(x + y) % 3] += 1
                boardX[(x + y) % 3][x][y] = 'X'
            k+=1

    minChanges = 1e9

    for i in range(3):
        for j in range(3):
            if i==j:
                continue
            if (changeX[i]+changeO[j]<=(int)(k/3)):
                minChanges = min(minChanges,changeX[i]+changeO[j])

    for i in range(3):
        for j in range(3):
            if i==j:
                continue
            if (changeX[i]+changeO[j]==minChanges):
                for x in range(n):
                    for y in range(n):
                        if board[x][y] == '.':
                            print('.',end='')
                        elif ((x+y)%3==i):
                            print(boardX[(x+y)%3][x][y],end='')
                        elif ((x+y)%3==j):
                            print(boardO[(x+y)%3][x][y],end='')
                        else:
                            print(board[x][y],end='')
                    print()
                return

if __name__ == '__main__':
    f = open("input.txt","r")
    t = int(f.readline())
    for _ in range(t):
        solve()