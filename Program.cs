using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Course22
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class employee
    {
        public string name { get; set; }
        public string department { get; set; }
        public int salary { get; set; }

        public employee(string name,string department,int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> my_list = new List<int>();
            my_list.Add(1);
            my_list.Add(2);
            my_list.Add(3);
            my_list.Add(4);
            my_list.Add(5);

            my_list.Insert(0, 0); // insert(index,number)
            my_list.InsertRange(1, new List<int> { 44, 45 });

            my_list.Remove(4);//remove by value
            my_list.RemoveAt(1);//remove by index
            my_list.RemoveAll(n => n % 2 == 0);//if this condition is true remove his element
            my_list.Clear();// clearing the list

            for (int i = 0; i < my_list.Count(); i++)
            {
                Console.WriteLine(my_list[i]);
            }
            foreach (int number in my_list)
            {
                Console.WriteLine(number);
            }
            my_list.ForEach(number => Console.WriteLine(number));

            Console.WriteLine(my_list.Sum());// the same for : max,min,avg,count

            //LINQ
            Console.WriteLine("even number ", string.Join(", ", my_list.Where(n => n % 2 == 0)));
            Console.WriteLine("every two numbers ", string.Join(", ", my_list.Where((n, index) => index % 2 == 1)));

            //sorting
            my_list.Sort();
            my_list.Reverse();
            my_list.OrderBy(n => n);
            my_list.OrderByDescending(n => n);

            //to search or find
            Console.WriteLine(my_list.Contains(44));//return true or false
            Console.WriteLine(my_list.Exists(n => n > 50));//return true or false
            Console.WriteLine(my_list.Find(n => n > 10));//return first value
            Console.WriteLine(my_list.FindAll(n => n < 50));//return all values
            Console.WriteLine(my_list.Any(n => n == 44));//return true or flase

            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };
            Console.WriteLine(words.Contains("banana"));
            Console.WriteLine(words.Exists(word => word.Length == 5));

            int[] array1 = my_list.ToArray();

            List<int> list_from_array = new List<int>(array1);

            List<Person> p = new List<Person>
            {
                new Person("amr",22),
                new Person("ali",53),
                new Person("talaat",88),
                new Person("atef",11)
            };
            p.Add(new Person("toka", 33));

            p.Insert(1,new Person("sasa", 29));

            foreach (Person p1 in p)
            {
                Console.WriteLine($"Name: {p1.name}, Age: {p1.age}");
            }

            Person find_p = p.Find(k => k.name == "toka");
            Console.WriteLine("founded name "+find_p.name);

            if(p.Exists(q=>q.name=="atef"))
                Console.WriteLine("Atef is here");

            List<Person> p2 = p.FindAll(q => q.age > 30);
            foreach(Person i in p2)
            {
                Console.WriteLine($"name: {i.name} , age: {i.age}");
            }

            //dictionarey is faster than hashtable as it doesn't need boxing

            Dictionary<string, int> fruits = new Dictionary<string, int> { { "tomato",41} };
            fruits.Add("banana", 5);
            fruits.Add("apple", 45);
            fruits.Add("orange", 20);

            foreach(KeyValuePair<string, int>f in fruits)
            {
                Console.WriteLine($"fruit: {f.Key}, number: {f.Value}");
            }
            
            if(fruits.TryGetValue("apple",out int quantity))
                Console.WriteLine($"quantity of apples is: {quantity}");
            
            //LINQ 
            var f_result = fruits.Where(kvp => kvp.Value > 20);
            foreach(var kp in f_result)
                Console.WriteLine($"Fruit {kp.Key}, quantity: {kp.Value}");
            
            int total = fruits.Sum(kvp => kvp.Value);

            var filtered = fruits.Where(j => j.Value > 20)
                .OrderBy(j => j.Key)
                .Select(j => new { j.Key, j.Value });

            Dictionary<string, string> list3 = new Dictionary<string, string>
            {
                {"banana","tanta" },
                {"apple","benha" },
                {"orange","ALX" },
                {"tomato","benha" },
                {"onion","ALX" },

            };

            var x = list3.GroupBy(k =>k.Value);

            foreach(var i in x)
            {
                Console.WriteLine($"GV: {i.Key}");
                foreach(var y in i)
                {
                    Console.WriteLine($"- {y.Key}");
                }
            }

            // hashset is not indexing
            //you can just use foreach to see all items
            HashSet<string> h1 = new HashSet<string> { "apple", "banana", "tomato" };
            foreach(string h2 in h1)
                Console.WriteLine(h2);

            if(h1.Contains("banana"))
                Console.WriteLine("banana is here");

            //how to remove dublicates in array?

            //using hashset

            int[] arr = new int[] { 1, 2, 2, 3, 4, 5, 5 };
            HashSet<int> hr = new HashSet<int>(arr);

            foreach(int i in hr)
                Console.WriteLine(i);

            Console.WriteLine("------------------");

            HashSet<int> num1 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7 };
            var res1 = num1.Where(m => m % 2 == 0);
            foreach(var x1 in res1)
                Console.WriteLine(x1);

            Console.WriteLine("****************");

            HashSet<string> names1 = new HashSet<string> { "amr", "ali", "mimi", "toka" };
            var res2 = names1.Where(m1 => m1.StartsWith("a"));
            foreach(var x2 in res2)
                Console.WriteLine(x2);

            Console.WriteLine("---------------------------");

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 2, 3, 4, 5 };

            set1.UnionWith(set2); //removes duplicate

            foreach(int x3 in set1)
                Console.WriteLine(x3);

            Console.WriteLine("------------------");

            HashSet<int> set3 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set4 = new HashSet<int> { 2, 3, 4, 5 };
            set3.IntersectWith(set4);// exceptwith 

            foreach(int x4 in set3)
                Console.WriteLine(x4);

            Console.WriteLine("--------------------");

            HashSet<int> set5 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set6 = new HashSet<int> { 2, 3, 4, 5 };

            set5.SymmetricExceptWith(set6);// remove duplicate form result

            foreach(int x5 in set5)
                Console.WriteLine(x5);

            Console.WriteLine("----------------");

            HashSet<int> set7 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set8 = new HashSet<int> { 1,2, 3, 4, 5 };
            Console.WriteLine(set7.SetEquals(set8));
            Console.WriteLine(set7.IsSubsetOf(set8));
            Console.WriteLine(set8.IsSupersetOf(set7));
            Console.WriteLine(set8.Overlaps(set7));//if any item is in set7 and set8 return true

            Console.WriteLine("----------------");

            var sortlist = new SortedList<string, int> { { "tomato",7} };// faster in search but slower at insert and delete
            sortlist.Add("apple", 5);
            sortlist.Add("orange", 4);
            sortlist.Add("banana", 2);

            var query = from kvp in sortlist
                        where kvp.Value > 4
                        select kvp; // same as next where statment

            var wherstatment = sortlist.Where(kvp => kvp.Value > 4);

            foreach (var x4 in query)
                Console.WriteLine(x4);
            foreach(var x5 in wherstatment)
                Console.WriteLine(x5);

            Console.WriteLine("------------");

            var groups = sortlist.GroupBy(kvp => kvp.Key.Length);
            foreach (var x6 in groups)
            { 
                Console.WriteLine($"length {x6.Key}: {string.Join(",", x6.Select(kvp => kvp.Key))}");
            }

            Console.WriteLine("----------------------");

            SortedList<int, employee> s_list = new SortedList<int, employee>
            {
                {1,new employee("Ali","IT",7000) },
                {2,new employee("Amr","HR",8000) },
                {3,new employee("Atef","IT",4000) },
                {4,new employee("Alaa","HR",9000) }
            };

            var query2 = s_list.Where(k => k.Value.department == "IT").OrderByDescending(k => k.Value.salary)
                .Select(k => k.Value.name);
            foreach(var x7 in query2)
                Console.WriteLine((x7));

            Console.WriteLine("---------------------");

            SortedSet<int> s_set = new SortedSet<int>(); //same as sortedlist but it includes just values not key,value like sortedlist
            // doesn;t have index in for loop

            s_set.Add(4);
            s_set.Add(2);
            s_set.Add(1);
            s_set.Add(3);
            foreach(int x8 in s_set)
                Console.WriteLine(x8);

            Console.WriteLine("----------------------");

            var filtered_set = s_set.Where(e => e > 2);//sum,min,avg,orderbydesc(x=>x)
            //unionwith ,
            foreach(var x9 in filtered_set)
                Console.WriteLine(x9);

            Console.WriteLine("----------------");

            var square_of_even = s_set.Where(e1 => e1 % 2 == 0).Select(e2 => e2 * e2);
            foreach(var x10 in square_of_even)
                Console.WriteLine(x10);

            Console.WriteLine("-----------");

            SortedDictionary<string, int> s_dict = new SortedDictionary<string, int>();

            s_dict.Add("orange", 5);
            s_dict.Add("apple", 6);
            s_dict.Add("banana", 7);
            foreach(var x11 in s_dict)
                Console.WriteLine($"key: {x11.Key}, value: {x11.Value}");

            Console.WriteLine("--------------");

            ArrayList arrlist = new ArrayList(); // it's hetrogenious (can include different types of data)
            //it's dynamic memory(can increase jis memory but use "TrimToSize()" to reduce size

            arrlist.Add(1);
            arrlist.Add(5);
            arrlist.Add(4);
            arrlist.Add(2);
            arrlist.Add(3);

            foreach(int x12 in arrlist)
                Console.WriteLine(x12);

            var filter2 = arrlist.Cast<int>().Where(g => g % 2 == 0).Select(g2=>g2*g2).OrderBy(g3=>g3); //use cast to convert all to int
            foreach(var x13 in filter2)
                Console.WriteLine(x13);

            //aggregate functions 
            // min,max,avg , sum,count ,string.join

            Console.WriteLine("----------------");

            int ex = arrlist.Cast<int>().Count(g3 => g3 % 2 == 0);
            Console.WriteLine(ex);
        }
    }
}
