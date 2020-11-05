// Problem: Dat n con hau len ban co nxn khong con nao an con nao
#include <bits/stdc++.h>
using namespace std;

// Hoan vi
class permutions{
    int n,x[100],d[100]={};

    public:void TRY(int k){
      if (k == n){
        for (int i=1; i<=n; i++){
          cout << x[i] << " ";
        }

        cout << endl;

        return;
      }

      for (int i=k; i<=n; i++){
        if (d[i]==0){
          x[k+1]=i;
          d[i]=1;
          TRY(k+1);
          d[i]=0;
        }
      }
    }

  public:void sol(){
    cin >> n;
    TRY(0);
  }
};

int main(){
  freopen("input.txt","r",stdin);
  freopen("output.txt","w",stdout);

  permutions x;
  x.sol();
}
