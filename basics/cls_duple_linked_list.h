#pragma once
using namespace std;
#include"iostream"
#include <vector>
template <class t> class cls_duple_linked_list
{
protected:
    int _size = 0;
    
public:
    class Node
    {
    public:
        t value;
        Node* next;
        Node* prev;
    };
    Node* head = NULL;

    void insert_at_front( t value)
    {
        Node* neww = new Node();
        neww->value = value;
        neww->next = head;
        neww->prev = NULL;
        if (head != NULL)
        {
            head->prev = neww;
        }
        head = neww;
        _size++;

    }

    Node* find( t value)
    {
        Node* current = head;
        while (current != NULL)
        {
            if (current->value == value)
                return current;

            current = current->next;
        }
        return NULL;
    }

    void print_list()

    {
        Node* current = head; //do this because head is changed in object , so this method save head as it

        while (current != NULL)
        {
            cout << current->value << " ";
            current = current->next;
        }
        cout << endl;
        cout << endl;
    }

    void insert_after(Node* n, t value)
    {
        Node* neww = new Node();
        neww->value = value;
        neww->next = n->next;
        neww->prev = n;
        if (n->next != NULL)
        {
            n->next->prev = neww;
        }
        n->next = neww;
        _size++;
    }

    void insert_at_end( t value)
    {
        Node* neww = new Node();
        neww->next = NULL;
        neww->value = value;
        if (head == NULL)
        {
            head = neww;
            head->prev = NULL;
            
        }
        else
        {
            Node* cc = head;
            while (cc->next != NULL)
            {
                cc = cc->next;
            }
            cc->next = neww;
            neww->prev = cc;
        }
        _size++;
    }

    void delete_node( Node*& nodedelete)
    {
        if (head == NULL || nodedelete == NULL)
            return;
        if (nodedelete == head)
            head = nodedelete->next;
        if (nodedelete->next != NULL)
            nodedelete->next->prev = nodedelete->prev;
        if (nodedelete->prev != NULL)
            nodedelete->prev->next = nodedelete->next;
        delete nodedelete;
        _size--;
    }

    void delete_first_node()
    {
        if (head == NULL)
            return;
        Node* temp = head;
        head = head->next;
        if (temp->next != NULL)
            temp->next->prev = NULL;
        delete temp;

        _size--;
    }

    void delete_last_node()
    {
        Node* n = head;
        Node* prev = n, * curr = n;
        if (n == NULL)
            return;
        curr = curr->next;
        while (curr->next != NULL)
        {
            prev = curr;
            curr = curr->next;
        }
        prev->next = NULL;
        delete curr;
        _size--;
    }

    int size_linked_list() 
    {
    //O(n) very slow when use large lunked list
        //Node* n = head;
        //int num = 0;
        //while (n != NULL)
        //{
        //    num++;
        //    n = n->next;
        //}
        return _size;
    }

    bool is_empty()
    {
        return _size == 0;
    }

    void clear()
    {
        while (_size > 0)
            delete_first_node();

    }

    void reverse()
    {
        Node* curr = head;
        Node* temp = nullptr;
        while (curr != nullptr)
        {
            temp = curr->prev;
            curr->prev = curr->next;
            curr->next = temp;
            curr = curr->prev; //move to next point
        }
        if (temp != nullptr)
        {
            head = temp->prev;
        }

    }

    Node* node_by_index(int num)
    {
        int count =0 ;
        Node* current=head;
        while (current != NULL && current->next != NULL)
        {
            if (num == count)
            {
                break;
            }
            current = current->next;
            count++;
        }
        return current;
    }

    t get_value_by_index(int num)
    {
        cls_duple_linked_list<int>::Node* n2 =node_by_index(num);
        if (n2 == NULL)
            return NULL;
        else
            return (n2->value);
    }

    void update_item(int index, int value)
    {
        Node* n = node_by_index(index);
        n->value = value;
        //insert_after(n, value);
        //delete_node(n);
    }

    void insert_after_index(int index, int value)
    {
        Node* n = node_by_index(index);
        insert_after(n, value);
    }

};


