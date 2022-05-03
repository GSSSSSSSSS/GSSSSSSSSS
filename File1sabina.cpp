//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include <tchar.h>
//---------------------------------------------------------------------------

#pragma argsused
#include <iostream>
using namespace std;
int main()
{
	int a = 777;
	while (true)
	{
		cout << "Address : " << &a  << " = " << a << endl;
		char ch = getchar();
		if (ch == 'e') break;
	}
	return 0;
}

//---------------------------------------------------------------------------
