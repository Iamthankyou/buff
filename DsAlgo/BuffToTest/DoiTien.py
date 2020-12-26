class money:
    def __init__(self):
        self.arr = list(map(int,input().split()))
        self.M = int(input())
        self.min = self.M+1
        self.solve()

    def TRY(self,ans,k,T):
        if len(ans) == len(self.arr)-1:
            if (self.M-T)%self.arr[-1] == 0:
                k = (self.M-T)//self.arr[-1]
                total = sum(ans)+k
                if total<self.min:
                    self.min = total
                    print(*(ans+[k]),sep=" ")
        else:
            for i in range((self.M-T)//self.arr[k]+1):
                self.TRY(ans+[i],k+1,T+self.arr[k]*i)

    def solve(self):
        self.TRY([],0,0)
        if self.min == self.M+1:
            print("Can't change money")
        else:
            print("Min: ",self.min)
if __name__ == '__main__':
    Money = money()