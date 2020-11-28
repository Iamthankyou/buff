#include<bits/stdc++.h>
using namespace std;
int main()
{
	freopen("input.txt","r",stdin);
	deque<int> Q;
	int n,k;
	scanf("%d%d",&n,&k);
	int a[n+5];
	for(int i=1;i<=n;i++)  scanf("%d",&a[i]);
	for(int i=1;i<k;i++)
	{
		while(Q.size() && a[Q.back()]<=a[i])  Q.pop_back();
		Q.push_back(i);
	}

	cout << Q.front();


	for(int i=k;i<=n;i++)
	{
		while(Q.size()&&a[Q.back()]<=a[i])  Q.pop_back();
		deque<int> tmp = Q;

		while (tmp.size()){
			cout << tmp.front();
			tmp.pop_front();
		}

		cout << "/n";

		while(i-Q.front()>=k) Q.pop_front();

		printf("%d ",a[Q.front()]);
	}
}
