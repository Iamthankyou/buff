class Queen:
    def __init__(self):
        self.n = int(input())
        self.A = {}
        self.B = {}
        self.C = {}

        self.TRY([],1)

    def TRY(self,ans,k):
        if len(ans) == self.n:
            for i in ans:
                print('-'*(i-1)+'*'+'-'*(self.n-i))
            print()
        else:
            for i in range(1,self.n+1):
                if (i not in self.A or self.A[i] == False) and ((i-k) not in self.B or self.B[i-k] ==False ) and ((i+k) not in self.C or self.C[i+k]==False):
                    self.A[i] = self.B[i-k] = self.C[i+k] = True
                    self.TRY(ans+[i],k+1)
                    self.A[i] = self.B[i-k] = self.C[i+k] = False
if __name__ == '__main__':
    q = Queen()
