from bisect import bisect_left

def solve():
    n = int(input())
    arr = list(map(int,input().split()))
    ans = []

    for i in range(len(arr)):
        if ans == [] or ans[-1]<arr[i]:
            ans.append(arr[i])
        else:
            ans[bisect_left(ans,arr[i])] = arr[i]

    print(ans)

if __name__ == '__main__':
    solve()

