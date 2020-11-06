def backTracking(x,T,n):
    if T==n:
        print(*x[1:])
    else:
        for t in range(x[-1],n-T+1):
            backTracking(x+[t],T+t,n)

if __name__ == '__main__':
    backTracking([1],0,5)