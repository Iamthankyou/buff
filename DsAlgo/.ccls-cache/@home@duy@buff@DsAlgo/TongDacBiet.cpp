#include <bits/stdc++.h>
using namespace std;

int main(){
  ios_base::sync_with_stdio(false);
  cin.tie(NULL);
  cout.tie(NULL);

  freopen("input.txt","r",stdin);

  long long n;
  vector<pair<long long, long long>> v;

  cin >> n;
  for (int i=2; i*i<=2*n; i++){
    if ((2*n)%i==0 && (2*n/i-i+1)%2==0){
        v.push_back(make_pair((2*n/i-i+1)/2,(2*n/i-i+1)/2 + i-1));
    }
  }

  cout << v.size() << endl;

  for (auto i:v)
    cout << i.first << " " << i.second << endl;

}
