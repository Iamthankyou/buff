class edge:
    def __init__(self,u,v,w):
        self.u,self.v,self.w=u,v,w
    def __str__(self):
        return str(self.u) + "-" str(seft.v) + ":" + str(self.w)

class Graph:
    def read(self):
        f=open("input.txt","r")
        self.n,self.m=map(int,f.readline().split())
        self.A=[]

        for _ in range(n):

    def getroot(self,x):
        if (self.D[x]==0): return x
        return self.getroot(self.D[x])

    def Kruskal(self):
        self.A.sort(key=lambda x:x.w)
        res=0

        for e in self.A:
            if (self.getroot(e.u)!=self.getroot(e.v)):
                self.D[x] = y
