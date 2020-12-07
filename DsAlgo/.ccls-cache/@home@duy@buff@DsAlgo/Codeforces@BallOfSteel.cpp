#include <bits/stdc++.h>
using namespace std;

int main(){
	//freopen("input.txt","r",stdin);
	int t;
	cin >> t;

	while (t--){
		int n,k,res = 0;
		cin >> n >> k;
		vector<pair<int,int>> point(n);

		for (int i=0; i<n; i++){
			cin >> point[i].first >> point[i].second;
		}

		sort(point.begin(),point.end());
		for (int i=0; i<n; i++){
			for (int j=0; j<n; j++){
				if (abs(point[i].first-point[j].first) + abs(point[i].second-point[j].second)<=k){
					res = 1;
				}
				else{
					res = -1;
					break;
				}
			}

			if (res == 1){
				break;
			}
		}

		cout << res << "\n";
	}
}
