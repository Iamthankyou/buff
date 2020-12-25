from math import sqrt,floor

class zero:
    def __init__(self,n):
        self.n = n
        self.check = [0]*(n+1)

    def DFS(self,n):
        for i in range(1,floor(sqrt(n))+1):
            if n%i==0:
                t = (i-1)*(n//i+1)
                if self.check[t] == 0:
                    self.check[t] = 1
                    print(t)
                    self.DFS(t)

    def solve(self):
        self.DFS(self.n)

if __name__ == '__main__':
    n = int(input())
    z = zero(n)
    z.solve()