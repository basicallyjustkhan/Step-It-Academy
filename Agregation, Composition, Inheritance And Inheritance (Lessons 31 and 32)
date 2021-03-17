// Learned you code fully.

#include <iostream>
using namespace std;

struct Node
{
	int data = 0;
	Node* next = NULL;

	Node(int x = 0)
	{
		data = x;
	}
};

Node* FindMiddle(Node* root)
{
	Node* slowptr = root;
	Node* fastptr = root;
	while (fastptr != NULL)
	{
		fastptr = fastptr->next;
		if (fastptr != NULL)
		{
			fastptr = fastptr->next;
			if (fastptr != NULL) slowptr = slowptr->next;
		}
	}

	return slowptr;
}

Node* Merge(Node* left, Node* right)
{
	Node* root = new Node();
	Node* temp = root;
	while (left != NULL && right != NULL)
	{
		if (left->data < right->data)
		{
			temp->data = left->data;
			left = left->next;
		}
		else
		{
			temp->data = right->data;
			right = right->next;
		}
		if (left != NULL || right != NULL)
		{
			temp->next = new Node();
			temp = temp->next;
		}
	}
	while (left != NULL)
	{
		temp->data = left->data;
		left = left->next;
		if (left != NULL)
		{
			temp->next = new Node();
			temp = temp->next;
		}
	}
	while (right != NULL)
	{
		temp->data = right->data;
		right = right->next;
		if (right != NULL)
		{
			temp->next = new Node();
			temp = temp->next;
		}
	}
	return root;
}

Node* MergeSort(Node* root)
{
	if (root->next == NULL) return root;
	Node* middle = FindMiddle(root);
	Node* temp = middle->next;
	middle->next = NULL;
	Node* left = MergeSort(root);
	Node* right = MergeSort(temp);
	root = Merge(left, right);
	return root;
}

void PrintList(Node* root)
{
	while (root != NULL)
	{
		cout << root->data << endl;
		root = root->next;
	}
}

int main()
{
	Node* root = new Node(5);
	root->next = new Node(7);
	root->next->next = new Node(6);
	root->next->next->next = new Node(3);
	root->next->next->next->next = new Node(2);
	root->next->next->next->next->next = new Node(9);
	root->next->next->next->next->next->next = new Node(1);

	root = MergeSort(root);
	PrintList(root);
}
