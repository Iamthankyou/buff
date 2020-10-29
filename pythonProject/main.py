def backTracking(x,k,t,n,m):
    if (k==n-1):
        x.append(m-t)
        print(*x)
    else:
        for i in range(m-t+1):
            backTracking(x+[i],k+1,t+i,n,m)

backTracking([],0,0,3,5)
