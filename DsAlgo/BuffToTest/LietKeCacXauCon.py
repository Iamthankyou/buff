ans = set()

def solve(s):
    if len(s)>1:
        if s[:-1] not in ans:
            ans.add(s[:-1])
            solve(s[:-1])
        if s[1:] not in ans:
            ans.add(s[1:])
            solve(s[1:])

if __name__ == '__main__':
    s = input() 
    ans.add(s)
    solve(s)
    print("\n".join(sorted(list(ans))))