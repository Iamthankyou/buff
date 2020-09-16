arr = [3,2,1,6,99,3,9,8]
first,second = float('-inf')

for i in arr:
    if i>first:
        first,second = i,first
    elif i>second:
        second = i
print(i)




