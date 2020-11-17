def add(A, B):
    size = max(m, n);
    sum = [0 for i in range(size)]

    for i in range(0, m, 1):
        sum[i] =

    for i in range(n):
        sum[i] += B[i]

    return sum

def printPoly(poly, n):
    for i in range(n):
        print(poly[i], end="")
        if (i != 0):
            print("x^", i, end="")
        if (i != n - 1):
            print(" + ", end="")

if __name__ == '__main__':
    a = int(input())+1
    A = list(map(int,input().split()))
    b = int(input())+1
    B = list(map(int, input().split()))
    c = int(input())+1
    C = list(map(int, input().split()))



    m = len(A)
    n = len(B)

    printPoly(A, m)
    printPoly(B, n)

    sum = add(A, B, m, n)
    size = max(m, n)

    printPoly(sum, size)
