def TRY(ans,T,n):
    if T==n:
        print(n," = ",end=' ')
        print(*ans[1:],sep="+")
    else:
        for t in range(ans[-1],n-T+1):
            TRY(ans+[t],T+t,n)
if __name__ == '__main__':
    TRY([1],0,3)