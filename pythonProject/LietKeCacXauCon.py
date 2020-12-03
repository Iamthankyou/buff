if __name__ == "__main__":
    a = set()
    string = input()
    j = 1
    while True:
        for i in range(len(string) - j + 1):
            a.add(string[i:i + j])
        if j == len(string):
            break
        j += 1
    print ("\n".join(sorted(list(a))))
