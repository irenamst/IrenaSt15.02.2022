#include <iostream>
using namespace std;
int fun1(int p) {
	++p;
	return p++;
}
int fun2(int& p) {
	++p;
	return p++;
}
int main(void) {
	int a = 1, b, c;
	b = fun1(a);
	c = fun2(b);
	cout << a << endl;
	cout << b << endl;
	cout << c << endl;
	cout << a + b + c << endl;
	return 0;
}