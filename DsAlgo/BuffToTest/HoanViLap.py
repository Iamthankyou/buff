class Permution:
    def solve(self):
        self.s = input()
        self.D = {}

        for i in self.s:
            if i not in self.D.keys():
                self.D[i]=1
            else:
                self.D[i]+=1
        self.TRY([])
    def TRY(self,ans):
        if len(ans) == len(self.s):
            print("".join(ans))
        else:
            for i in self.D.keys():
                if self.D[i]>0:
                    self.D[i]-=1
                    self.TRY(ans+[i])
                    self.D[i]+=1

if __name__ == '__main__':
    p = Permution()
    p.solve()