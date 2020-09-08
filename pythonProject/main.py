def taylor(x,n):
    res=0
    i=0
    for _ in range(n):
        c = (((-1) ** n) / ((2 * n) + 1)) * (x ** ((2 * n) + 1))
        n += 1
        res += c
        yield res

if __name__ == "__main__":
    res = 0
    i=0
    for j in taylor(i,1000):
        res = j*4
        i+=1
    print(res)