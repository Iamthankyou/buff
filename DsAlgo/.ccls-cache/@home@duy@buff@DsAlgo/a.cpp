#include <bits/stdc++.h>
using namespace std;

int main(){
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	
	// freopen("input.txt","r",stdin);
	
	int n;
	long res = 0;
	cin >> n;
	int arr[n],L[n],R[n];
	
	for (int i=0; i<n; i++)
		cin >> arr[i];
	
	L[0] = arr[0];
	R[n-1] = arr[n-1];
	
	for (int i=1; i<n; i++)
		L[i] = max(L[i-1],arr[i]);
	
	for (int i=n-2; i>=0; i--)
		R[i] = max(R[i+1],arr[i]);
		
	for (int i=1; i<n-1; i++)
		if (min(L[i-1],R[i+1])>arr[i])
			res+=min(L[i-1],R[i+1])-arr[i];

	cout << res;
}
