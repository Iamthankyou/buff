from queue import PriorityQueue
from math import *

class elem:
    def __init__(self,v,c):
        self.value,self.cost =v,c
    def __lt__(self,other):
        return self.cost<other.cost

def path(u,p[v]):
    if u.value==f:
        path()

if __name__ == '__main__':
    s,f = map(int,input().split())
    q=priorityQueue()
    p=[1e9]*(s+5)
    q.put(elem(s,0))

    while q.qsize():
        u=q.get()

        for a in range(1,floor(sqrt(u.value))+1):
            if u.value%a==0:
                b=u.value//a
                v=(a-b)*(b+1)
                c=b//a if b%a==0 else b-a
                if L[v]>L[u.value]+c:
                    q.put(elem(v,c))
                    p[v]=u
