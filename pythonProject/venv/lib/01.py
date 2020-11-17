from math import sqrt

if __name__ == "__main__":

    a,b,c =map(int,input().split())

    if a == 0:
        if b == 0:
            if c == 0:
                print("vo so nghiem")
            else:
                print("vo nghiem")
        else:
            if c == 0:
                print("{:.3f}".format(0))
            else:
                print("{:.3f}".format(-c*1.0/b))
    else:
        delta = b ** 2 - 4 * a * c
        if delta < 0:
            print("vo nghiem")
        elif delta == 0:
            print("{:.3f}".format(-b*1.0 / (2 * a)))
        else:
            print(min("{:.3f}".format(float((-b - sqrt(delta)) / (2 * a))),"{:.3f}".format(float((-b + sqrt(delta)) / (2 * a)))))
            print(max("{:.3f}".format(float((-b - sqrt(delta)) / (2 * a))),"{:.3f}".format(float((-b + sqrt(delta)) / (2 * a)))))


