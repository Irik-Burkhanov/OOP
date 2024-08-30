#include <iostream>
#include <string>
#include <stdio.h>
using namespace std;

void Static_Object_Point();
void Dinamic_Object_Point();
void Static_Object_Color();
void Dinamic_Object_Color();
void ColorPoint_Descen();
void Static_Object_Section();
void Dinamic_Object_Section();


class Point {
protected:
	int x, y;
public:
	Point() : x(0), y(0) {
		printf("Point()\n");

	}
	Point(int x, int y) : x(x), y(y) {
		printf("Point(int x, int y)\n");

	}
	Point(const Point& p) : x(p.x), y(p.y) {
		printf("Point(const Point& p)\n");

	}
	~Point() {
		printf("%d %d\n", x, y);
		printf("~Point()\n");
	}
	void move(int dx, int dy) {
		x = x + dx;
		y = y + dy;
	}
	void reset();

	int get_X() {
		return x;
	}

	int get_Y() {
		return y;
	}
};

void Point::reset() {
	x = 0;
	y = 0;
}

class ColorPoint : public Point
{
protected:
	string color;
public:
	ColorPoint() : Point(), color("black") {
		printf("ColorPoint()\n");

	}
	ColorPoint(int x, int y, string color) : Point(x, y), color(color) {
		printf("ColorPoint(int x, int y, string color)\n");

	}
	ColorPoint(const ColorPoint& p) : Point(p), color(p.color) {
		printf("ColorPoint(const ColorPoint& p)\n");

	}
	~ColorPoint() {
		printf("%d %d color = %s\n", x, y, color.c_str()); //c_str() возвращает указатель на область памяти, где хранит саму строку
		printf("~ColorPoint()\n");
	}
	void change_color(string new_color) {
		color = new_color;
	}
};

class Section {
protected:
	Point* p1;
	Point p2;
public:
	Section() : p1(new Point()), p2() {
		printf("Section()\n");
		//p1 = new Point();
		//this->p2 = Point();
	}
	Section(int x1, int y1, int x2, int y2) : p1(new Point(x1, y1)), p2(x2, y2) {
		printf("Section(int x1, int y1, int x2, int y2)\n");
		//p1 = new Point(x1, y1);
		//this->p2 =  Point(x2, y2);
	}
	Section(const Section& s) : p1(new Point(*(s.p1))), p2(s.p2) {
		printf("Section(const Section& s)\n");
		//p1 = new Point(*(s.p1));
		//this->p2 =  Point((s.p2));
		//p1 = s.p1;
		//p2 = s.p2;
	}
	~Section() {
		delete p1;

		printf("~Section()\n");
	}
	float calk_length() {
		int a = p1->get_X() - p2.get_X();
		int b = p1->get_Y() - p2.get_Y();
		return sqrt(a * a + b * b);
	}
};

int main() {
	setlocale(LC_ALL, "ru");
	int c = 0;
	do {
		system("cls");
		printf("1)Static_Object_Point\n2)Dinamic_Object_Point\n3)Static_Object_Color\n4)Dinamic_Object_Color\n5)ColorPoint_Descen\n6)Static_Object_Section\n7)Dinamic_Object_Section\n");
		printf("Выберите функцию-проверку: ");
		int funk;
		scanf_s("%d", &funk);
		switch (funk) {
		case 1:
			system("cls");
			Static_Object_Point();
			break;
		case 2:
			system("cls");
			Dinamic_Object_Point();
			break;
		case 3:
			system("cls");
			Static_Object_Color();
			break;
		case 4:
			system("cls");
			Dinamic_Object_Color();
			break;
		case 5:
			system("cls");
			ColorPoint_Descen();
			break;
		case 6:
			system("cls");
			Static_Object_Section();
			break;
		case 7:
			system("cls");
			Dinamic_Object_Section();
			break;
		default:
			break;
		}
		printf("\nЧто бы продолжить введите: 1\nЧто бы выйти введите любую цифру\n");
		scanf_s("%d", &c);
		printf("\n");
	} while (c == 1);
	return 0;
}

void Static_Object_Point() {
	Point p;
	Point p1(2, 3);
	Point p2(p1);
	p.move(1, 1);
}

void Dinamic_Object_Point() {
	Point* p = new Point;
	Point* p1 = new Point(2, 3);
	Point* p2 = new Point(*p1);
	p->move(1, 1);
	delete p;
	delete p1;
	delete p2;
}

void Static_Object_Color() {
	ColorPoint p;
	ColorPoint p1(2, 3, "white");
	ColorPoint p2(p1);
	p.move(1, 1);
	p2.change_color("blue");
}

void Dinamic_Object_Color() {
	ColorPoint* p = new ColorPoint;
	ColorPoint* p1 = new ColorPoint(2, 3, "white");
	ColorPoint* p2 = new ColorPoint(*p1);
	p->move(1, 1);
	p2->change_color("blue");
	delete p;
	delete p1;
	delete p2;
}

void ColorPoint_Descen() {
	Point* p1 = new ColorPoint(2, 3, "white");
	delete p1;
}

void Static_Object_Section() {
	Section s1;
	Section s2(8, 6, 0, 0);
	Section s3(s2);
	float len = s2.calk_length();
	printf("Длина отрезка = %.1f\n", len);
}

void Dinamic_Object_Section() {
	Section* s1 = new Section;
	Section* s2 = new Section(8, 6, 0, 0);
	Section* s3 = new Section(*s2);
	float len = s2->calk_length();
	printf("Длина отрезка = %.1f\n", len);
	delete s1;
	delete s2;
	delete s3;
}