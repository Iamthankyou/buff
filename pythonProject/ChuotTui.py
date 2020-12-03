import bisect

if __name__ == '__main__':
    n = int(input())
    arr = []
    for _ in range(n):
        arr.append(int(input()))
    arr.sort()
    tmp = arr[::-1]
    for i in range(len(tmp)):
        pos = bisect.bisect_left(arr,tmp[i]//2+1)
        if pos!=0:
            arr = arr[:pos-1] + arr[pos:]

    print(len(arr))