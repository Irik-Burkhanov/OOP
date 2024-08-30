#include <iostream>

// методы в методе

class Base{
public:
    Base(){
        printf("Base::Base\n");
    }

    void method1(){
        printf("Base::method1\n");
        method2();
    }

    void method2(){
        printf("Base::method2\n");
    }

    virtual ~Base(){
        printf("Base::~Base\n");
    }
};

class Desc : public Base{
public:
    Desc(){
        printf("Desc::Desc\n");
    }

    void method2(){
        printf("Desc::method2\n");
    }

    void method1_1() {
        printf("Desc::method1_1\n");
        method2_2();
    }

    void virtual method2_2() {
        printf("Desc::method2_2\n");
    }
    ~Desc(){
        printf("Desc::~Desc\n");
    }
};

class Desc2 : public Desc{
public:
    Desc2(){
        printf("Desc2::Desc2\n");
    }

    void method2_2() {
        printf("Desc2::method2_2\n");
    }

    ~Desc2(){
        printf("Desc2::~Desc2\n");
    }
};


int main() {
    Base b;
    printf("\n");
    Desc d;
    printf("\n");
    Desc2 d2;
    printf("\n");

    b.method1();
    printf("\n");
    d.method1();
    printf("\n");
    d2.method1_1();
    printf("\n");

    return 0;
}
