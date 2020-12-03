#include <bits/stdc++.h>
using namespace std;
typedef pair<string,int> psi;
int main()
{
	freopen("input.txt","r",stdin);
	int test;
	cin>>test;
	while(test--)
	{
		queue<psi> Q;
		string res[]={"dangdungcntt", "tienquanutc", "quang123", "maianh", "nguyenminhduc2820"};
		for(auto x:res) Q.push({x,1});
		int n;
		cin>>n;
		while(n>Q.front().second)
		{
			n-=Q.front().second;
			Q.push({Q.front().first,Q.front().second*2});
			Q.pop();
		}
		cout<<Q.front().first<<"\n";
	}
}
