#include <iostream>
using namespace std;

int main() {
	int x = 8;
	int& synx = x;
	synx = 2;
	cout << x;
	return 0;
}