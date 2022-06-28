#include <iostream>
#include <string>	//string::find()
#include <wchar.h>
using namespace std;
int wchar_size(const wchar_t *_string)
{
	int cnt = 0;
	while (_string[cnt] != '\0')
	{
		cnt++;
	}
	return cnt;
}
int test_wcsmp(const wchar_t *_string1, const wchar_t *_string2)
{
	int len = wchar_size(_string1);
	int len2 = wchar_size(_string2);
	int templen = len >= len2 ? len : len2;
	for (int i = 0;  i < templen; i++)
	{
		if (_string1[i] == _string2[i])
			continue;
		if (_string1[i] > _string2[i])
			return 1;
		else
			return -1;
	}
	return 0;
}
int main() {
	
	//char ch;
	//while ((ch = cin.get()) != EOF) {
	//	//cout.put(ch);
	//	if (ch == '\n')
	//		break;
	//}
	int iRet1 = wcscmp(L"abaa", L"aba");
	int iRet = test_wcsmp(L"abaa", L"aba");


	return 0;
}