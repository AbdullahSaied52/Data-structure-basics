#pragma once
#include"cls_dynamic_array.h"
using namespace std;
template<class t>

class cls_queue_arr:public cls_dynamic_array<t>
{
protected:
	cls_dynamic_array <t>_myque;
public:

	void push(t num)
	{
		_myque.insert_at_end(num);
	}

	int size()
	{
		return _myque.size_linked_list();
	}

	t front()
	{
		return _myque.get_item(0);
	}

	int end()
	{
		return _myque.get_value_by_index(size() - 1);
	}

	void pop()
	{
		_myque.delete_last_node();
	}

	void print()
	{
		_myque.print_list();
	}

	int get_item_by_index(int i)
	{
		return _myque.get_value_by_index(i);
	}

	void revers()
	{
		_myque.reverse();
	}

	void update_item_by_index(int i, t value)
	{
		_myque.update_item(i, value);
	}

	void inser_after(int i, t value)
	{
		_myque.insert_after_index(i, value);
	}

	void insert_at_front(t value)
	{
		_myque.insert_at_beginning(value);
	}

	void insert_at_end(t value)
	{
		_myque.insert_at_end(value);
	}

	void clear()
	{
		_myque.clear();
	}

};

