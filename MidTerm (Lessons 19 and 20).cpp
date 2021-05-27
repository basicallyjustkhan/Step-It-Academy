Self-Learning:

1. Stack - Is kind of an Array which also stores variables.But different from an Array you can input a variable into a stack using push(); or to extract you use pop();
"stack" is the library name.

2. Queue - The difference between stacks and queues is in removing.In a stack we remove the item the most recently added; in a queue, we remove the item the least recently added.



----------------------------------------------------------------------------------------------------------------------------------------------------------------
Bu dinamik melumat strukturlaridir. Onlar barede info yigin, methodlarina baxin ve aralirandaki esas ferqleri tapin:

- In Stack elements can be only inserted and deleted only from one side of the list, called the top.


Yigdiginiz butun melumatlari, ve test etdiyiniz butun kodlari ev tapshirigina gonderin:

#include <iostream> 
#include <stack> 
using namespace std;

int main()
{
    // Empty stack 
    stack<int> mystack;
    mystack.push(0);
    mystack.push(1);
    mystack.push(2);

    // Printing content of stack 
    while (!mystack.empty()) {
        cout << ' ' << mystack.top();
        mystack.pop();
    }
}
