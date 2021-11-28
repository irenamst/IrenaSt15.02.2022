#include <iostream>
#include <stdio.h>

using namespace std;
class Pixel {
private:
	int x, y;

public:
	int getx() { return x; }
	int gety() { return y; }
	void set(int, int);
	void drawpixel();
};
void Pixel::set(int a, int b)
{
	x = a;
	y = b;
}
/*void Pixel::drawpixel()
{
	putpixel(x, y, 2);
}
int main(void) {
	Pixel p1, p2;
	p1.set(20,30);
	p2.set(50, 100);
	p1.drawpixel();
	p2.drawpixel();
	cout << "Hello";
	return 0;
}
*/