import re
import collections
if __name__ == '__main__':
    t = int(input())
    for _ in range(t):
        s = input()
        x = re.findall(r"([A-Z][a-z]*)(\d*)|(\()|(\))(\d*)",s)
        stack = [collections.Counter()]

        for name, m1, leftBracket, rightBracket, m2 in x:
            if name:
                stack[-1][name] += int(m1 or 1)
            if leftBracket:
                stack.append(collections.Counter())
            if rightBracket:
                top = stack.pop()
                for k in top:
                    stack[-1][k] += top[k] * int(m2 or 1)

        res = 0
        top = stack.pop()
        for k in top:
            if k == 'H':
                res += (top[k] or 0)
            elif k == 'O':
                res += (top[k] or 0) * 16
            else:
                res += (top[k] or 0) * 12
        print(res)

