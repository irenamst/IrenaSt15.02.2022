#include <iostream>
using namespace std;
class A {
	int a;
public:
	A(void) { a = 1; }
	int b(void) { return ++a; }
};
int main(void) {
	A a;
	a.b();
	cout << a.b() << endl;
	cout << a.b() << endl;
	return 0;
}