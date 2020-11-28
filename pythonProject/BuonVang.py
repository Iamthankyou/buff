if __name__ == '__main__':
    input()
    arr = list(map(int,input().split()))[::-1]
    res = 0
    m = 0
    for i in arr:
        if i>=m:
            m=i
        else:
            res += m-i

    print(res)