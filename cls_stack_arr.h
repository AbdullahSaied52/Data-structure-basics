#pragma once
#include "cls_queue_arr.h"
template<class t>
class cls_stack_arr:public cls_queue_arr<t>
{
public:
	void push(t n)
	{
		cls_queue_arr<t>::_myque.insert_at_beginning(n);
	}
	t top()
	{
		return cls_queue_arr<t>::front();
	}
	t button()
	{
		return cls_queue_arr<t>::end();
	}
};

