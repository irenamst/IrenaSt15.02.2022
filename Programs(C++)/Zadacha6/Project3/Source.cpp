#include <iostream>
using namespace std;
char f1(char c) {
	return c == 'z' ? 'a' : c + 1;
}
char f2(char& c) {
	c = f1(c);
	return c;
}
int main(void) {
	char x = 'x';
	cout << f2(x);
	cout << f2(x);
	cout << f2(x) << endl;
	return 0;
}