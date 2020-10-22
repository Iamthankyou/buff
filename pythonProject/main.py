class poly:
    def __init__(self,h):
        seft.a=h

    def __add(self, other):
        k=max(len(self.a),len(other.a))
        b=k*[0]
        for i,x in enumerate(self.a): b[i]+x
        for i,x in enumerate(self.b): b[i]+x
        return poly(b)
    def __str(self):
        s=["%.3f".format(self.x) for x in self.a]
        return " ".join(s)

if __name__ == '__main__':
    n=input()
    p=poly([float(x) for x in input().split()])

    n = input()
    q = poly([float(x) for x in input().split()])

    n = input()
    r = poly([float(x) for x in input().split()])

    print(p+q+r)



