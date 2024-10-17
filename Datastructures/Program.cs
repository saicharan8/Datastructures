
using System.Collections;

#region Arrays

int[] array = new int[5] { 1, 2, 3, 5, 0 };
//insertion - O(n)
ArrayList arrayList = new ArrayList();
arrayList.Insert(0, array);
//deletion - O(n)
array = array.Where((x, i) => i != 0).ToArray();
//search - O(n)
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 4)
    {
        Console.WriteLine("found");
    }
}
//access - 0(1)
Console.WriteLine(array[1]);

#endregion


#region Stacks

Stack<int> stack = new Stack<int>();

//Stack stack2 = new Stack();
//stack2.Push(1);
//stack2.Push("ss");
//Console.WriteLine(stack2.Peek());

//insertion - O(1)
stack.Push(1);
stack.Push(2);
stack.Push(3);

//deletion - O(1)
stack.Pop();

//search - O(n)
// for loop or top  element with stack.peep()

//access - O(n)
//self implement
//store stack.pop() and then stack.push

#endregion

#region Queue

Queue queue = new Queue();

//insertion - O(1)
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

//deletion - O(1)
queue.Dequeue();

//search - O(n)
//foreach


//access - O(1)
//queue.Peek();
Queue<int> queue2 = new Queue<int>();

queue2.Enqueue(1);
queue2.Enqueue(4);
queue2.Enqueue(0);
queue2.Enqueue(4);
//access - O(n)
//queue.Peek();
Console.WriteLine(queue2.ElementAt(2));

#endregion


#region Single|Double linkedList

// In C#, by default it is double linked list
LinkedList<int> list = new LinkedList<int>();

//insertion - O(1) -  reference will be available
var l1 = list.AddFirst(10);
list.AddAfter(l1, 12);
list.AddBefore(l1, 14);
list.AddLast(13);

//deletion - looping is O(n)
//as per doc it is assuming just remove assuming reference available i.e O(1)
list.Remove(15);
list.RemoveFirst();
list.RemoveLast();

//search- O(n)
list.Find(12);

//access - O(n)
//list.First.Next.Value;
list.ElementAt(2);

#endregion

#region HashSet
HashSet<int> set = new HashSet<int>();
Hashtable Hashtable = new Hashtable();
//insertion - O(1)
set.Add(3);
set.Add(4);

//deletion -O(1)
set.Remove(4);

#endregion

#region HashTable
Hashtable hashtable = new Hashtable();

//insertion - O(1)
hashtable.Add("name","sai");
hashtable.Add("age", 25);

//deletion - O(1)
hashtable.Remove("age");

//access - n/a no index at all we cannot access like in arrays - arry[0]
Console.WriteLine(hashtable["name"]);

//search - O(1) assuming containskey - no need to iterate
foreach (DictionaryEntry item in hashtable)
{
    Console.WriteLine(item.Key);
}

#endregion


#region SortedSet -REDBLACKTREE
SortedSet<string> strings= new SortedSet<string>();

//insertion - O(1)
strings.Add("1");
strings.Add("2");
strings.Add("3");
//deletion - O(1)
strings.Remove("3");

#endregion
