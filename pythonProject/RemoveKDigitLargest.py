if __name__ == '__main__':
    s = input()
    t = int(input())

    for _ in range(t):
        restore = s
        k = int(input())
        i = 0
        while k>0 and i<len(s)-1:
            if s[i]<s[i+1]:
                s = s[:i] + s[i + 1:]
                i = max(0,i-1)
                k=k-1
            else:
                i=i+1
        print(s)
        s = restore