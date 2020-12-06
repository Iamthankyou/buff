#include <bits/stdc++.h>
using namespace std;

int main(){
	//freopen("input.txt","r",stdin);
	int t;
	cin >> t;

	while (t--){
		int n;
		string s;
		cin >> n;
		cin >> s;
		int j=0;

		for (int i=0; i<s.length(); i++){
			if (s[i]=='b'){
				swap(s[j++],s[i]);
			}
		}

		cout << s << "\n";
	}
}
