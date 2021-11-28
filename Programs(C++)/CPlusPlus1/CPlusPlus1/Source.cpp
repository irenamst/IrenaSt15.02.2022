#include <iostream>
template <typename T>
class Container {
	T t;

public:
	explicit Container(T t) : t(t) {

	}
	friend std::ostream& operator<<(
		std::ostream& os,
		const Container<T>& c) {
		return(os << "Container holding:" << c.t);
	}
};
template<typename X>
bool isGreater(X x1, X x2) {
	return x1 > x2;
}
template<>
bool isGreater(int x1, int x2) {
	std::cout << "Specialized for int\n";
	return x1 > x2;
}
using namespace std;
int main() {
	cout << std::boolalpha;
	Container<int> c(100);
	Container<string>s("Some String");
	cout << c << "\n";
	cout << s << "\n";
	cout << isGreater(5, 10) << "\n";
	cout << isGreater(42.34,10.876) << "\n";
	cout << isGreater("ZZZ","AAAA")<<"\n";
	cout << isGreater('c','r')<<"\n";
	auto f = [] <typename T>(T t1, T t2) {
		return t1 == t2;
	}
	return 0;

}