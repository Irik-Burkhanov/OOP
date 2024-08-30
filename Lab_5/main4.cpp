#include <iostream>

class Base{
public:
    Base(){
        printf("Base::Base\n");
    }

    Base(Base *obj){
        printf("Base::Base(Base *obj)\n");
    }

    Base(Base &obj){
        printf("Base::Base(Base &obj)\n");
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
    Desc(Desc *obj){
        printf("Desc::Desc(Desc *obj)\n");
    }
    Desc(Desc &obj){
        printf("Desc::Desc(Desc &obj)\n");
    }
    ~Desc(){
        printf("Desc::~Desc\n");
    }
};

void func1(Base b){
    printf("func1(Base b)\n");
}

void func2(Base *b){
    printf("func2(Base *b)\n");
}

void func3(Base &b){
    printf("func3(Base &b)\n");
}


int main() {

    Base b1;
    Base *b2 = new Base();

    printf("\n\n\n");

    func1(b1);
    func2(&b1);
    func3(b1);

    printf("\n\n\n");

    func1(*b2);
    func2(b2);
    func3(*b2);

    printf("\n\n\n");

    Desc d1;
    Desc *d2 = new Desc();
    Base *d3 = new Desc();

    printf("\n\n\n");

    func1(d1);
    func2(&d1);
    func3(d1);

    printf("\n\n\n");

    func1(*d2);
    func2(d2);
    func3(*d2);

    printf("\n\n\n");

    func1(*d3);
    func2(d3);
    func3(*d3);

    printf("\n\n\n");

    delete b2;
    delete d2;
    delete d3;

    printf("\n");

    return 0;
}
