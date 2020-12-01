#include <bits/stdc++.h>
using namespace std;

int main(){
	freopen("input.txt","r",stdin);
	string s;
	cin >> s;
	int t;
	cin >>t;
	while (t--){
		string restore = s;
		int i=0;
		int k;
		cin >> k;
		while (k>0 && i<s.length()-1){
			if (s[i]<s[i+1]){
				s = s.substr(0,i) + s.substr(i+1,s.length()-1);
				k--;
				i = max(0,i-1);
			}
			else{
				i++;
			}
		}

		cout << s << endl;
		s = restore;
	}
}
