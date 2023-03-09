#include <iostream>
#include <list>
using namespace std;

class Node
{
	int _data{};
	Node* next{};
	friend class LinkedList;

public:
	Node(int data) : _data(data), next(NULL) { }
};

class LinkedList
{
	Node* head{};
	int count{};

public:
	LinkedList() : head(NULL) { }

	void push_back(int data)
	{
		Node* newNode = new Node(data);
		if (head == NULL)
		{
			newNode->next = NULL;
			head = newNode;
		}
		else
		{
			Node* temp = head;
			while (temp->next != NULL)
			{
				temp = temp->next;
			}
			temp->next = newNode;
			newNode->next = NULL;
		}
		count++;
	}

	void push_front(int data)
	{
		Node* newNode = new Node(data);
		if (head == NULL)
		{
			newNode->next = NULL;
			head = newNode;
		}
		else
		{
			newNode->next = head;
			head = newNode;
		}
		count++;
	}

	void insert(int index, int data)
	{
		
	}

	void pop_back()
	{
		if (count == 0) return;
		else if (count == 1)
		{
			delete head;
			head = NULL;
		}
		else
		{
			Node* prev = head;
			Node* current = head->next;

			while (current->next != NULL)
			{
				prev = current;
				current = current->next;
			}
			prev->next = NULL;
			delete current;
			count--;
		}
	}

	void pop_front()
	{
		if (count == 0) return;
		else if (count == 1)
		{
			delete head;
			head = NULL;
		}
		else
		{
			Node* newHead = head->next;
			delete head;
			head = newHead;
		}
		count--;
	}

	void remove(int number)
	{
		Node* prev = NULL;
		Node* temp = NULL;
		if (head != NULL)
		{
			prev = head;
			if (head->next != NULL)
				temp = head->next;
		}
		if (prev != NULL && prev->_data == number)
		{
			pop_front();
			return;
		}
		while (temp != NULL && temp->_data != number)
		{
			prev = temp;
			temp = temp->next;
		}
		if (temp != NULL && temp->_data == number)
		{
			prev->next = temp->next;
			delete temp;
		}
	}

	void removeAll(int number) {}

	void makeAllNodesUnique() {}

	void clear() {}

	void printList()
	{
		Node* temp = head;
		while (temp != NULL)
		{
			cout << temp->_data << endl;
			temp = temp->next;
		}
	}

	int size() { return count; }
};

void PrintList(const list<int>& list)
{
	cout << "----------------------\n";
	for (auto it = list.begin(); it != list.end(); ++it)
	{
		cout << *it << "  ";
	}
	cout << "\n----------------------";
}

void PrintReverse(const list<int>& list)
{
	cout << "----------------------\n";
	for (auto it = list.rbegin(); it != list.rend(); ++it)
	{
		cout << *it << "  ";
	}
	cout << "\n----------------------";
}

void insert(list<int>& list, int number, int near)
{
	auto it = list.cbegin();
	while (it != list.cend())
	{

		++it;
	}
}

int main()
{
	list<int> lst = { 1, 5, 6, 7, 8, 9, 6, 5, 4, 3, 3, 3, 3, 3, 3, 5, 4, 5, 4, 5, 4, 5, 4, 6, 3, 7, 3, 2 };
	//lst.reverse();
	lst.sort();
	lst.unique();
	PrintList(lst);
	//insert(lst, 55, 5);
}

/*
* .begin() - iterator to first element
* .end() - iterator to next of last element
* .rbegin() - iterator to last element
* .rend() - iterator to previous of first element
* .cbegin() - const iterator to first element
* .cend() - const to next of last element
*/
