#include <bits/stdc++.h>
using namespace std;

// Problem: x1+x2+..+xk = n


void backTracking(int *x, int k, int t, int n, int m){ // x1+..x,<=T<=M
  if (k==n-1){
    x[n] = m-t;

    for (int i=1; i<=n; i++){
      cout << x[i] << " ";
    }

    cout << endl;
  }
  else{
    for (x[k+1]=0; x[k+1]<=m-t; x[k+1]++){
      backTracking(x, k+1, t+x[k+1],n,m);
    }
  }
}

int main(){
  freopen("input.txt","r",stdin);
  freopen("output.txt","w",stdout);

  int n;
  cin >> n;
  int x[1000];

  backTracking(x,0,0,3,n);

}
