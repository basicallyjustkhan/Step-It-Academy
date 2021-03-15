#include <algorithm>
#include <iostream>
#include <vector>
using namespace std;

class BinaryTreeNode
{
public:
    int value{};

    BinaryTreeNode* right{};
    BinaryTreeNode* left{};
};

class BinaryTree
{
private:
    BinaryTreeNode* root;

public:
    BinaryTree() : root(new BinaryTreeNode) {};

    void push(int _value)
    {
        if (root->value == NULL) { root->value = _value; return; }

        BinaryTreeNode* main = root;
        BinaryTreeNode* previous = root;

        int maino = 0;
        bool sides = 0;

        while (true)
        {
            if (_value > main->value) { main = main->right; sides = 0; }
            else if (_value < main->value) { main = main->left; sides = 1; }

            if (main == NULL)
            {
                main = new BinaryTreeNode;
                main->value = _value;

                if (sides) { previous->left = main; }
                else { previous->right = main; }
                break;
            }
            else
            {
                if (sides) { previous = previous->left; }
                else { previous = previous->right; }
            }
        }
    }

    void print()
    {
        vector<int> test;

        print2(root, test);
        sort(test.begin(), test.end());

        for (int i = 0; i < test.size(); i++) { cout << test[i] << endl; }
    }

    vector<int> print2(BinaryTreeNode* root, vector<int>& result)
    {
        if (root == NULL) { return result; }

        result.push_back(root->value);
        print2(root->left, result);
        print2(root->right, result);
        return result;
    }

    void printInorder()
    {
        easyWayToAvoidTheError(root);
    }

    void easyWayToAvoidTheError(BinaryTreeNode* root)
    {
        if (root == NULL) { return; }
        easyWayToAvoidTheError(root->left);
        cout << root->value << endl;
        easyWayToAvoidTheError(root->right);
    }
};

int main()
{
    BinaryTree test;

    test.push(25);
    test.push(70);
    test.push(68);
    test.push(8);
    test.push(33);
    test.printInorder();
}
