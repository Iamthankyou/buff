import math
n = int(input())
list = []
i=2

while i*i<=2*n:
    x = 2*n/i-i+1
    if ((2*n)%i==0 and (x%2)==0):
        list.append((x/2,x/2+i-1))
    i+=1

print(len(list))
for i in list:
    print(int(i[0]),int(i[1]))