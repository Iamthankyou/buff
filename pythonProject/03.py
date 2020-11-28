
if __name__ == "__main__":
    x1,y1 = map(float,input().split())
    x2,y2 = map(float,input().split())
    x3,y3 = map(float,input().split())
    x4,y4 = map(float,input().split())
    print((1/2*((x1*y2-x2*y1)+(x2*y3-x3*y2)+(x3*y4-x4*y3)+(x4*y1-x1*y4))))

'''
    A = np.array([[x1,x2],[y1,y2]])
    B = np.array([[x2,x3], [y2,y3]])
    C = np.array([[x3,x4], [y3,y4]])
    D = np.array([[x4,x1], [y4,y1]])

    print("{:.2f}".format((1/2)*(np.linalg.det(A)+np.linalg.det(B)+np.linalg.det(C)+np.linalg.det(D))))
'''



