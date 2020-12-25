#include<bits/stdc++.h>
using namespace std;
int main()
{
	int a,b,c,d,SL,var1,var2,var3;
	cout<<"Tong gui: ";
	cin>>a;
	cout<<"MTU_1 = ";
	cin>>b;
	cout<<"MTU_2 = ";
	cin>>c;
	cout<<"Tim byte cua DataGram thu: ";
	cin>>d;
	SL = (int) a/(b-20);
	var1 = b - c + 20;
	if(a%(b-20) != 0 ){
		SL++;
	}
	var2 = SL * 20 + a%b;
	if(var2 > c) SL = SL * 2; else SL = (SL * 2) - 1;
		if(d%2 == 0) var3 = b - c + 20;
		if(d%2 != 0) var3 = c;
		if(d == SL && var2 > c) var3 = var2 - c + 20;
		if(d == SL && var2 <= c) var3 = var2;	
	cout<<"\nSo luong DataGram: "<<SL<<"\tSo byte cua DataGram thu "<<d<<" la: "<<var3-20;
}

