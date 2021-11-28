#include <iostream>
using namespace std;
int* fun(void) {
	return new int[2];
}
int fun(int* p) {
	delete[]p;
	return 0;
}
void fun(int* p, int q) {
	p[q] *= 2;
}
void fun(int* p, int q, int r) {
	p[q] = r;
}
int main(void) {
	int* v = fun();
	fun(v, 0, 1);
	fun(v, 1, 2);
	fun(v, 0);
	cout << v[1] + v[0] << endl;
	return 0;
}