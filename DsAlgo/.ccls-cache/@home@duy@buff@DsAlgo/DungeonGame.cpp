#include <bits/stdc++.h>
using namespace std;

class Try
{
    int n,m;
    int A[101][101];
    public:
        void init();
        int search(pair<int,int> *x,int k,pair<int,int> f);
};

void Try::init()
{
	freopen("input.txt","r",stdin);
	cin >> m >> n;

	for (int i=1; i<=m; i++){
		for (int j=1; j<=n;j++){
			cin >> A[i][j];
		}

	}

	for (int i=0; i<m; i++){
		A[i][0] = A[i][m+1] = 1;
	}

	 for (int i=0; i<n; i++){
		   A[0][i] = A[0][n+1] = 1;
	 }

    pair<int,int> s,f;

    cin >> s.first >> s.second >> f.first >> s.second;

    cout << s.first << s.second << "?";

    pair<int,int> *x=new pair<int,int>[n*m+1];

    cout << "??";
    x[1]=s;
    int k=1;

    A[s.first][s.second]=1;

    int t = search(x,&k,f);

    cout << k;
}

int hh[]={0, -1,  0,  1};
int hc[]={1,  0, -1,  0};

int Try::search(pair<int,int> *x,int k, pair<int,int> f)
{
    cout << k;
    if(x[k]==f) return k;
    else
    {
        for (int i=0; i<4; i++)
        {
            x[k+1].first=x[k].first+hh[i];
            x[k+1].second=x[k].second+hc[i];
            if(A[x[k+1].first][x[k+1].second]==0)
            {
                A[x[k+1].first][x[k+1].second]=1;
                search(x,k+1,f);
                A[x[k+1].first][x[k+1].second]=0;
            }
        }
    }

    return k;
}

int main()
{
    Try M;
    M.init();
}
