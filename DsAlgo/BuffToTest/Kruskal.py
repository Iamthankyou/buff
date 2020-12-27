class edge:
    def __init__(self,u,v,w):
        self.u,self.v,self.w = u,v,w
    def __str__(self):
        return "("+str(self.u)+","+str(self.v)+","+str(self.w)+")"
class graph:
    def __init__(self):
        self.n,self.m = map(int,input().split())
        self.G = []

        for _ in range(self.m):
            u,v,w = map(int,input().split())
            self.G.append(edge(u,v,w))
        self.D = [0]*(self.n+1)

    def findRoot(self,x):
        if self.D[x] == 0:
            return x
        return self.findRoot(self.D[x])

    def kruskal(self):
        self.G.sort(key=lambda x: x.w)
        ans = 0
        for i in self.G:
            rootU = self.findRoot(i.u)
            rootV = self.findRoot(i.v)
            if rootU!=rootV:
                self.D[rootU] = rootV
                print(i)
                ans+=i.w
        print(ans)

if __name__ == '__main__':
    G = graph()
    G.kruskal()
