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

Base out1(){
    printf("out1\n");
    Base b;
    return b;
}

Base out2(){
    printf("out2\n");
    Base *b = new Base();
    return *b;
}

Base* out3(){
    printf("out3\n");
    Base b;
    return &b;
}

Base* out4(){
    printf("out4\n");
    Base *b = new Base();
    return b;
}

Base& out5(){
    printf("out5\n");
    Base b;
    return b;
}

Base& out6(){
    printf("out6\n");
    Base *b = new Base();
    return *b;
}

int main() {

    Base b1 = out1();
    printf("\n\n\n");

    Base b2;
    b2 = out1();
    printf("\n\n\n");

    Base b3 = out2();
    printf("\n\n\n");

    Base b4;
    b4 = out2();
    printf("\n\n\n");

    Base *b5 = out3();
    printf("\n\n\n");

    Base *b6 = out4();
    printf("\n\n\n");

    Base &b7 = out5();
    printf("\n\n\n");

    Base &b8 = out6();
    printf("\n\n\n");

    return 0;
}
