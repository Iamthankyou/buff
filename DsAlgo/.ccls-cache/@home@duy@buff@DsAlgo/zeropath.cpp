#include <bits/stdc++.h>
using namespace std;

long long check[100001];

long long dfs(int u){
	for (int i=1; i*i<=u; i++){
		if (u%i==0){
			int a = i-1;
			int b = (int)u/i+1;

			if (a*b!=0){
				if (check[a*b]==0){
					check[a*b]=1;
					check[(a+1)*(b-1)]+=dfs(a*b)%(1000000000+7);
				}
				else{
					check[(a+1)*(b-1)]+=check[a*b]%(1000000000+7);
				}
			}
			else{
				check[(a+1)*(b-1)] = 1;
			}
		}
	}

	return check[u]%(1000000000+7);
}

int main(){
    for (int i=0; i<100001; i++){
        check[i] = 0;
    }


	check[0] = 1;

	//freopen("input.txt","r",stdin);
	ios_base::sync_with_stdio(false);

	int t;
	cin >> t;

	while(t--){
		int x;
		cin >> x;
		cout << dfs(x)<< "\n";
	}

}
