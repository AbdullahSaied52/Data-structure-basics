#pragma once

template <class t>
class cls_dynamic_array
{
private:
	int _size=0;
	t* _temp_array;
public:
	t* original_array;
	cls_dynamic_array(int n)
	{
		_size = n;
		original_array = new t[_size];
	}
	cls_dynamic_array()
	{
		_size = 0;
		original_array = new t[_size];
	}
	~cls_dynamic_array()
	{
		delete[] original_array;
	}

	void print_list()
	{
		
		for (int i = 0;i < _size;i++)
		{
			cout << original_array[i] << " ";
		}
		cout << endl;
	}

	void add_item(int index, t value)
	{
		original_array[index] = value;
	}

	void resize(int newsize)
	{
		if (newsize < 0)
			newsize = 0;

		_temp_array = new t[newsize];

		if (newsize < _size)
			_size = newsize;

		for (int i=0;i<_size;i++)
		{
			_temp_array[i] = original_array[i];
		}

		_size = newsize;
		delete[] original_array;
		original_array = _temp_array;
	}

	t get_item(int index)
	{
		return original_array[index - 1];
	}

	void reverse()
	{
		for (int i = 0;i < (_size / 2);i++)
		{
			int temp;
			temp = original_array[i];
			original_array[i] = original_array[_size - i - 1];
			original_array[_size - i - 1] = temp;
		}
	}

	void clear()
	{
		_size = 0;
		delete[] original_array;
		original_array = new t[0];
	}

	void delete_item(int index)
	{
		for (int i = index;i < _size - 1;i++)
		{
			original_array[i] = original_array[i + 1];
		}
		_size--;
		resize(_size);
	}

	void delete_first_item()
	{
		delete_item(0);
	}

	void delete_last_item()
	{
		delete_item(_size - 1);
	}

	t find(t value)
	{
		int index;
		for (int i = 0;i < _size;i++)
		{
			if (original_array[i] == value)
			{
				index = i;
			}
		}
		return index;
	}

	void delet(t value)
	{
		int i = find(value);
		delete_item(i);
	}

	void insert_at(int index, t value)
	{
		_size++;
		resize(_size);
		_temp_array = new t[_size];
		
		for (int i = 0;i <= _size;i++)
		{
			if (i >= index)
			{
				_temp_array[i+1] = original_array[i];
				
			}
			else
			{
				_temp_array[i] = original_array[i];
			}
		}
		_temp_array[index] = value;
		
		
		original_array = _temp_array;
	}

	void insert_at_beginning(t value)
	{
		insert_at(0, value);
	}

	void insert_at_end(t value)
	{
		insert_at(_size,value);
	}

	void insert_before(int index, t value)
	{
		insert_at(index-1, value);
	}

	void insert_after(int index, t value)
	{
		insert_at(index +1, value);
	}
};

