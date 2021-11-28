// ConsoleApplication3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main(void) {
	int t[4] = { 8, 4, 2, 1 };
	int* p1 = t + 2;
	int* p2 = p1 - 1;
	int* p3 = p2 - 1;
	int* p4 = t;
	//p1++;
	cout << *p1 << endl;
	cout << t[2] << endl;
	cout << *p2 << endl;
	cout << t[1] << endl;
	cout << t[p1 - p2] << endl;
	cout << *p1 - t[p1 - p2] << endl;
	//cout << *p1 << endl;
	//cout << t << endl;
	//cout << t[1] << endl;
	//cout << t[0] << endl;
	//cout << t[2] << endl;
	//cout << t + 1 << endl;
	//cout << t + 2 << endl;
	//cout << t[2] << endl;
	//cout << *p1 << endl;
	//cout << t + 2 << endl;
	//cout << p1 << endl;
	//cout << * p1 << endl;
	//cout << t + 2 << endl;
	//cout << t[2] << endl;
	//cout << *p1 << " " << t[2] << endl;
	//cout << *p2 <<" "<< t[1] << endl;
	//cout << *p3 <<" " << t[0] <<endl;
	//cout << *p4 <<" "<< t[0]<< " "<< t << endl;
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
