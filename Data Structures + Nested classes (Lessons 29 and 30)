#include <iostream>
using namespace std;


class Point
{
public:
	int x;
	int y;
};

class Line
{
private:
	Point A{};
	Point B{};

public:
	Line() {}
	Line(int x1, int y1, int x2, int y2)
	{
		A.x = x1;
		A.y = y1;

		B.x = x2;
		B.y = y2;
	}

	Line editPointA(int newX, int newY)
	{
		A.x = newX;
		A.y = newY;
	}

	Line editPointB(int newX, int newY)
	{
		B.x = newX;
		B.y = newY;
	}
	
	void printCoordinates() const
	{
		printPointA();
		printPointB();
	}

	void calculateDistance() const
	{
		int finalX = B.x - A.x;
		int finalY = B.y - A.y;

		cout << finalX << ", " << finalY << endl;
	}

	void printPointA() const
	{
		cout << "Point A(x, y):" << A.x << ", " << A.y << endl;
	}

	void printPointB() const
	{
		cout << "Point B(x, y):" << B.x << ", " << B.y << endl;
	}
};

int main()
{

}
