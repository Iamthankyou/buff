def taylor(x,n)
    res = 0
    i=0
    for in range(0,n)
        c = (((-1)**n)/((2*n)+1))*(x**((2*n)+1))
        i += 1
        res += c
    return res

if __name__ == "__main__":
    print(taylor(1,5)
