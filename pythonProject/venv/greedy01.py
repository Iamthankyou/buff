class event:
    def __init__(self,u=0,v=0):
        self.start,self.finish=u,v

if __name__ == '__main__':
    n=int(input())
    E=[]

    for _ in range(n):
        u,v=map(int,input().split())
        E.append(event(u,v))

    E.sort(key= lambda x:x.finish)
    dem=0
    time = E[0].start=1

    counter = 0

    for e in E:
        if e.start>time:
            counter+=1
            time=e.finish

    print("The number event is: ",counter)
