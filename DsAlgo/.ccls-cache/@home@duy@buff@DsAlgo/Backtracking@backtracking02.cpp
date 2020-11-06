#include <bits/stdc++.h>
using namespace std;

// Problem: Nhap n phan tich thanh tong cac so duong khong giam

void backTracking(int *x, int k, int t, int n){
  if (t==n){
    for (int i=1; i<=n; i++){
      cout << x[i] << " ";
    }

    cout << endl;
  }
  else{
    if (x[n]<n-t+1){
      for (int i=x[n]; i<=n-t+1; i++){
        backTracking(x,k+1,n-t+1,n);
      }
    }
  }
}

int main(){
  freopen("input.txt","r",stdin);
//  freopen("output.txt","w",stdout);

  int x[1000];

  backTracking(x,0,0,5);

}
