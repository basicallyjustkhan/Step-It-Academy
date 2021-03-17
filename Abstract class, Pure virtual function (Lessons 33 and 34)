#include <iostream>
using namespace std;


int main()
{
// final spesifikator for virtual methods:
// When used in a virtual function declaration or definition, 
// final specifier ensures that the function is virtual and specifies that 
// it may not be overridden by derived classes. The program is ill-formed 
// (a compile-time error is generated) otherwise.
// 
// 
// struct Base
// {
//     virtual void foo();
// };
//
// struct A : Base
// {
//     void foo() final; // Base::foo is overridden and A::foo is the final override
//     void bar() final; // Error: bar cannot be final as it is non-virtual
// };
//
// struct B final : A // struct B is final
// {
//     void foo() override; // Error: foo cannot be overridden as it is final in A
// };



// --------------------------------------------------------------------
// virtual destructor:
// A program with virtual destructor, it also has a v table and the derived classes will also have the v table. 
// 
// 
// class base
// {
// public:
//     base()
//     {
//         cout << "Constructing base \n";
//     }
//     virtual ~base()
//     {
//         cout << "Destructing base \n";
//     }
// };
// 
// class derived : public base
// {
// public:
//     derived()
//     {
//         cout << "Constructing derived \n";
//     }
//     ~derived()
//     {
//         cout << "Destructing derived \n";
//     }
// };
// 
// void main()
// {
//     derived* d = new derived();
//     base* b = d;
//     delete b;
//     getchar();
//     return 0;
// }



//--------------------------------------------------------------------
// pure virtual destructor:
//	The only difference between Virtualand Pure Virtual Destructor is, 
//	that pure virtual destructor will make its Base class Abstract, 
//	hence you cannot create object of that class.There is no requirement of 
//	implementing pure virtual destructors in the derived classes.
//
// 	   
//	class base
//	{
//	public:
//		base()
//		{
//			cout << "Constructing base \n";
//		}
//		virtual ~base() = 0; // This is a pure virtual destructor
//	};
//
//	class derived : public base
//	{
//	public:
//		derived()
//		{
//			cout << "Constructing derived \n";
//		}
//		~derived()
//		{
//			cout << "Destructing derived \n";
//		}
//	};
}
