from math import sqrt

def num(a,b,c):
    if a == 0:
        if b == 0:
            if c == 0:
                return -1
            else:
                return 0
        else:
            if c == 0:
                return 1
            else:
                if -c*1.0/b>0:
                    return 2
                elif -c*1.0/b>0 == 0 or -c*1.0/b>0 == 1:
                    return 1
                else :
                    return 0
    else:
        delta = b ** 2 - 4 * a * c
        if delta < 0:
            return 0
        elif delta == 0:
            if -b*1.0 / (2 * a)>0:
                return 2
            elif -b*1.0 / (2 * a)==0:
                return 1
            else:
                return 0
        else:
            count = 0
            if float((-b - sqrt(delta)) / (2 * a))>0:
                count+=2
            elif float((-b - sqrt(delta)) / (2 * a)) ==0 or float((-b - sqrt(delta)) / (2 * a)) ==1:
                count+=1

            if float((-b + sqrt(delta)) / (2 * a)) > 0:
                count+=2
            elif float((-b + sqrt(delta)) / (2 * a)) == 0 or float((-b + sqrt(delta)) / (2 * a)) ==1:
                count += 1

            return count

if __name__ == "__main__":
    a, b, c = map(float, input().split())
    print(num(a,b,c))


