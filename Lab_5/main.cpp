#include <iostream>

class Animal{
public:
    Animal(){
        printf("Animal:Animal\n");
    }

    virtual void sound(){
        printf("Animal:sound\n");
    }

    virtual void going(){
        printf("Animal:going\n");
    }

    virtual ~Animal(){
        printf("Animal:~Animal\n");
    }
};

class Cat : public Animal{
public:
    Cat(){
        printf("Cat:Cat\n");
    }

    void sound() override{
        printf("Cat:sound\n");
    }

    ~Cat() {
        printf("Cat:~Cat\n");
    }
};

class Point{
public:
    Point(){
        printf("Point:Point\n");
    }

    void virtual draw(){
        printf("Point:draw\n");
    }

    ~Point(){
        printf("Point:~Point\n");
    }
};

class Point3D : public Point{
public:
    Point3D(){
        printf("Point3D:Point3D\n");
    }

    void draw(){
        printf("Point3D:draw\n");
    }

    ~Point3D(){
        printf("Point3D:~Point3D\n");
    }
};

int main() {
    // переопределенный метод + деструкторы начиная с потомка до предка
    Point3D *p3d = new Point3D();
    p3d->draw();
    delete p3d;
    printf("\n");

    // не вызывается переопределенный метод + деструктор только предка
    Point *p = new Point3D();
    p->draw();
    delete p;
    printf("\n");

    // перекрытый метод/виртуальный + деструктор начиная с потомка до предка
    Animal *a = new Cat();
    printf("\n");
    a->sound();
    printf("\n");
    // наследуемый виртуальный метод
    a->going();
    printf("\n");
    delete a;

    return 0;
}
