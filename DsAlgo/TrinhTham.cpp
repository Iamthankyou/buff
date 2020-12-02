#include <bits/stdc++.h>
using namespace std;

int main(){
	//ios_base::sync_with_stdio(false);
	//cin.tie(NULL);

	//freopen("input.txt","r",stdin);
	deque<int> dq;
	int n,k;
	cin >> n >> k;
	int arr[n];

	for (int i=0; i<n ;i++){
		cin >> arr[i];
	}

	for (int i=0; i<k; i++){
		while (dq.size()>0 && arr[dq.back()]<=arr[i]){
			dq.pop_back();
		}
		dq.push_back(i);
	}

	for (int i=k-1; i<n; i++){
		while (dq.size()>0 && arr[dq.back()]<=arr[i]){
			dq.pop_back();
		}
		dq.push_back(i);

		while (i-dq.front()>=k){
			dq.pop_front();
		}

		cout << arr[dq.front()] << " ";
	}

}
