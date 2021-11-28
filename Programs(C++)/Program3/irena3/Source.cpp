#include <iostream>
#include <math.h>
using namespace std;
float discr(int a, int b, int c) {
	return b * b - 4 * a * c;
}
int main(void) {
	float a, b, c, x1, x2, d;
	cout << "Koeficienti za kvadratnoto uravnenie \n \n";
	cout << "a= "; cin >> a;
	cout << "b= "; cin >> b;
	cout << "c= "; cin >> c;
	cout << '\n';
	d = discr(a, b, c);
	if (d >= 0) {
		if (d > 0) {
			x1 = (-b + sqrt(d)) / (2 * a);
			x2 = (-b - sqrt(d)) / (2 * a);
		}
		else
			x1 = x2 = -b / (2 * a);
		cout << "Result : \n\n";
		cout << "x1=" << x1 << " x2= " << x2 << '\n';
	}
	else
		cout << "There is no solutions \n";
	return 0;
}