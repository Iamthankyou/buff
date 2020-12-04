from collections import deque

def remove_nums(nums, k):
    nums_len = len(nums)
    s = deque()
    result = ""

    s.appendleft(nums[0])

    while len(s) > 0 and k > 0 and start < nums_len:
        if nums[start] <= s[0]:
            s.appendleft(nums[start])
        else:
            s.popleft()
            k -= 1
            start -= 1
        if len(s) == 0:
            start += 1
            s.appendleft(nums[start])
        start += 1

    while len(s) > 0 and k > 0:
        s.popleft()
        k -= 1
    while len(s) > 0:
        result += s[-1]
        s.pop()

    while start < nums_len:
        result += nums[start]
        start += 1

    result = result.lstrip("0")
    if not result:
        return "0"
    return result

if __name__ == '__main__':
    s = input()
    t = int(input())

    for _ in range(t):
        k=int(input())
        if len(s) == 0:
            print("0")

        else:
            print(remove_nums(s, k))