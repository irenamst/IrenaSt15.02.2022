#include <iostream>
using namespace std;
namespace alpha { int var=1; }
namespace beta { int var = alpha::var + 1; }
int main(void) {
	cout << alpha::var << endl;
	cout << beta::var << endl;
	beta::var += alpha::var;
	cout << alpha::var << endl;
	cout << beta::var << endl;
	{
		using namespace beta;
		cout << var << endl;
	}
	return 0;
}