//stack ucun template class yaradin. dinamik massiv ile realizasiya olmalidir
//
//stack - in dola bileceyini nezere alin.Capacity default olaraq 10 olmalidir ve eger size == capacity->o 
//zaman siz kohne melumatlari itirmemek sherti yeni massiviniz ucun yeni(daha boyuk) yaddash 
//sahesi ayirmalisiniz, capacity - ni artirmalisiniz ve kohne melumatlari yeni yaddash sahesine kocur
//melisiniz ki, istifadeci sizin stack - e melumat push eledikde hec xeberi bele olmasin ki, stack dolmushdur.


#include <iostream>
using namespace std;


template <class T>
class stack
{
private:
    int indexPointer = 0;
    int arraySize = 10;
    const int minIndexPointer = 0;
    T* arr = new T[arraySize];


public:
    stack() {}

    T push_back(T num)
    {
        if (indexPointer > arraySize - 1)
        {
            cout << "Stack Over Flow!" << endl;

            arraySize++;
            int* temp = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                if (i < indexPointer)
                {
                    temp[i] = arr[i];
                }
                else if (i == indexPointer)
                {
                    temp[i] = num;
                }
                else if (i > indexPointer)
                {
                    temp[i] = arr[i - 1];
                }
            }
            delete[] arr;

            arr = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = temp[i];
            }
            delete[] temp;
        }
        else
        {
            arr[indexPointer] = num;
            indexPointer++;

            return num;
        }
    }

    T pop_back()
    {
        if (indexPointer < minIndexPointer)
        {
            cout << "Stack margin has been exceeded!" << endl;

            return -1;
        }
        else
        {
            indexPointer--;
            T valueArray = arr[indexPointer];
            arr[indexPointer] = 0;

            return valueArray;
        }
    }

    T top() const
    {
        if (indexPointer != minIndexPointer)
        {
            return arr[indexPointer - 1];
        }
        else
        {
            return arr[indexPointer];
        }
    }

    int size() const
    {
        int activeIndexs = 0;
        for (int i = 0; i < arraySize; i++)
        {
            if (arr[i] != 0)
            {
                activeIndexs++;
            }
        }

        return activeIndexs;
    }
};

void printStack(stack<int>& MyStack)
{
    int x = -1;
    if (MyStack.size() != 0)
    {
        x = MyStack.top();
        MyStack.pop_back();
        printStack(MyStack);
    }
    if (x != -1)
    {
        MyStack.push_back(x);
        cout << x << endl;
    }
}

int main()
{
    stack<int> MyStack;


    MyStack.push_back(20);
    MyStack.push_back(50);
    MyStack.push_back(26);
    MyStack.pop_back();
    MyStack.push_back(383);
    cout << MyStack.top() << endl;
    cout << MyStack.size() << endl;
    MyStack.push_back(323);
    MyStack.push_back(323);
    MyStack.push_back(323);
    MyStack.push_back(323);
    MyStack.push_back(323);
    MyStack.push_back(323);
    MyStack.push_back(323); // Filled 10
    cout << MyStack.push_back(323) << endl;

    cout << "------------" << endl;
    printStack(MyStack);
}
