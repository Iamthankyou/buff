// Cho a1,a2,..an chọn ra m phần tử sao cho m số được chọn lấy mod x được số lớn nhất

#include <bits/stdc++.h>
using namespace std;

class problem{
  int n,k,x[100],d[100]={};

public: void TRY(int i){
    for (int j=1; j<=n; j++){
      if (d[j]==0){
        x[i] = j;
        if (i==k){
          for (int i=1; i<=k; i++){
            cout << i << " ";
        }

          cout << endl;
        }
        else{
          d[j] = 1;
          TRY(i+1);
          d[j] = 0;
        }
      }
    }
  }

  public: void sol(){
    cin >> n;
    TRY(1);
  }
};

int main(){
  freopen("input.txt","r",stdin);
  freopen("output.txt","w",stdout);

  problem x;
  x.sol();
}
