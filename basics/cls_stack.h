#pragma once
#include <iostream>
using namespace std;
#include"cls_queue.h"

template<class t>

class cls_stack: public cls_queue <t>
{

public:
	void push(t item)
	{
		cls_queue<t> ::_my_list.insert_at_front(item);
	}
	int top()
	{
		return cls_queue<t>::front();
	}
	int button()
	{
		return cls_queue<t>::end();
	}
};

