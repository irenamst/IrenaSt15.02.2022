// ConsoleApplication4.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

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
	//++a;
	//cout << a << endl;
	//a++;
	//cout << a << endl;
	cout << fun1(a) << endl;
	//cout << a << endl;
	//cout << "b" << "=" << fun1(a) << endl;
	//cout << "c" << "=" << fun2(b) << endl;
	cout << b << endl;
	cout << a + b + c << endl;
	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
