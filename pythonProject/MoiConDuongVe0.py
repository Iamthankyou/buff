from math import sqrt
from functools import lru_cache

count = 0
sum = 0
check = [0]*100001
check[0] = 1
sum = 0
@lru_cache(maxsize=None)
def dfs(u):
    global count
    global check
    global sum

    sum = 0
    for i in range(1,int(sqrt(u))+1):
        if u%i==0:
            a = i-1
            b = u//i+1
            print(a,b)
            if a*b!=0:
                if check[a*b]==0:
                    check[a*b] = 1

                    check[(a+1)*(b-1)] += dfs(a*b)
                else:
                    count+=check[a*b]
                    check[(a+1)*(b-1)]+=check[a*b]
            else:
                check[(a+1)*(b-1)]=1

    return check[u]

if __name__ == '__main__':
    t = int(input())

    for _ in range(t):
        x = int(input())
        print(dfs(x) % (1000000000+7))

