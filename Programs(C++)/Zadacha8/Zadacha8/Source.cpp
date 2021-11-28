#include <iostream>
#include <string>
using namespace std;
int main(void) {
	string s = "Abc", t = "A";
	s = s + t;
	t = t + s;
	int x = s.compare(t);
	int y = s.length();
	int z = t.length();
	int i = s.compare(t) > 0;
	int j = s.length() < t.length();
	cout << x << endl;
	cout << y << endl;
	cout << z << endl;
	cout << i << endl;
	cout << j << endl;
	cout << i + j << endl;
	return 0;
}