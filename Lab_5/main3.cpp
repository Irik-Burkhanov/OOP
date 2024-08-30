#include <iostream>
using namespace std;

class Animal{
public:
    Animal(){
        printf("Animal::Animal\n");
    }

    virtual bool isA(const string &classname){
        return (classname == "Animal");
    }

    virtual string classname(){
        return "Animal";
    }

    virtual ~Animal(){
        printf("Animal::~Animal\n");
    }
};


class Cat : public Animal {
public:
    Cat(){
       printf("Cat::Cat\n");
    }

    void catchMouse(){
        printf("Cat::catchMouse\n");
    }

    bool isA(const string &classname) override{
        return (classname == "Cat") || Animal::isA(classname);
    }

    string classname() override{
        return "Cat";
    }

    ~Cat(){
        printf("Cat::~Cat\n");
    }
};

class Manul : public Cat {
public:
    Manul(){
        printf("Manul::Manul\n");
    }

    bool isA(const string &classname) override{
        return (classname == "Manul") || Cat::isA(classname);
    }

    string classname() override{
        return "Manul";
    }

    ~Manul(){
        printf("Manul::~Manul\n");
    }
};

class Dog : public Animal {
public:
    Dog(){
        printf("Dog::Dog\n");
    }

    void catchCat(){
        printf("Dog::catchCat\n");
    }

    bool isA(const string &classname) override{
        return (classname == "Dog") || Animal::isA(classname);
    }

    string classname() override{
        return "Dog";
    }

    ~Dog(){
        printf("Dog::~Dog\n");
    }
};

int main() {
    Animal* animal[5];
    for (int i = 0; i < 5; ++i) {

        if (rand()%2 == 0){
            animal[i] = new Manul();
            printf("\n");
        }
        else {
            animal[i] = new Dog();
            printf("\n");
        }
    }
    printf("\n");
    for (int i = 0; i < 5; ++i) {

        if (animal[i]->classname() == "Manul" && animal[i]->isA("Cat")) static_cast<Manul*>(animal[i])->catchMouse();
        else static_cast<Dog*>(animal[i])->catchCat();

        Cat *c = dynamic_cast<Cat*>(animal[i]);
        if (c != nullptr) c->catchMouse();

        printf("\n\n");
    }

    for (int i = 0; i < 5; ++i) {
        delete animal[i];
        printf("\n");
    }

    return 0;
}
