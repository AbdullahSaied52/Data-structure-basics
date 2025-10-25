#pragma once
using namespace std;

#include<iostream>
#include<stack>
class cls_string
{
private:
	string _value;
	stack<string> _undo;
	stack<string>_redo;
public:
	void Set(string v)
	{
		_undo.push(_value);
		_value = v;
	}
	string Get()
	{
		return _value;
	}
	__declspec(property(get = Get, put = Set)) string value;

	void undo()
	{
		if (!_undo.empty())
		{
			_redo.push(_value);
			_value = _undo.top();
			_undo.pop();
		}
	}

	void redo()
	{
		if (!_redo.empty())
		{
			_undo.push(_value);
			_value = _redo.top();
			_redo.pop();
		}
	}
};

