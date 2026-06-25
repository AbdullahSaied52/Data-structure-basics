#pragma once
#include "cls_duple_linked_list.h"
using namespace std;
template<class t> class cls_queue 
{

protected:
	cls_duple_linked_list<t> _my_list;
public:

	void push(t num)
	{
		_my_list.insert_at_end(num);	
	}
	
	int size()
	{
		return _my_list.size_linked_list();
	}

	int front()
	{
		return _my_list.get_value_by_index(0);
	}

	int end()
	{
		return _my_list.get_value_by_index(size() - 1);
	}

	void pop()
	{
		_my_list.delete_last_node();
	}

	void print()
	{
		_my_list.print_list();
	}

	int get_item_by_index(int i)
	{
		return _my_list.get_value_by_index(i);
	}

	void revers()
	{
		_my_list.reverse();
	}

	void update_item_by_index(int i, int value)
	{
		_my_list.update_item(i, value);
	}

	void inser_after(int i, int value)
	{
		_my_list.insert_after_index(i, value);
	}

	void insert_at_front(int value)
	{
		_my_list.insert_at_front(value);
	}

	void insert_at_end(int value)
	{
		_my_list.insert_at_end(value);
	}

	void clear()
	{
		_my_list.clear();
	}


};

