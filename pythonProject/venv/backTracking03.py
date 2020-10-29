class money:
    def nhap(self):
        self.a=list(map(int,input().split()))
        self.M=int(input())
        self.n=len(self.a)

    def backTracking(self,x,k,T):
        if (len(x) == self.n-1):
            if (self.M-T)%self.a[-1] == 0:
                t=(self.M-T)//self.a[-1]
                print(*(x+[t]), sep=" ")
        else:
            for t in range((self.M-T)//self.a[k]+1):
                self.backTracking(x+[t],k+1,T+t*self.a[k])

    def sol(self):
        self.nhap()
        self.backTracking([],0,0)

if __name__ == '__main__':
    mon=money()
    mon.sol()
