using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    //List<String> li = new List<String>(); //have dup
    // li.Add("sam");
    // li.Add("raj");
    // li.Add("sara");
    // li.Add("riya");
    
    //HashSet<String> li = new HashSet<String>();//hashset - no dup
    // li.Add("sam");
    // li.Add("raj");
    // li.Add("sara");
    // li.Add("riya");
    // li.Add("riya");
    
    //SortedSet<String> li = new SortedSet<String>();//sortedset - asc order, no dup, unique ele
    // li.Add("sam");
    // li.Add("raj");
    // li.Add("sara");
    // li.Add("riya");
    // li.Add("riya");
    
    // Stack<String> li = new Stack<String>();//stack
    // li.Push("sam");
    // li.Push("raj");
    // li.Push("sara");
    // Console.WriteLine(li.Peek());
    // Console.WriteLine(li.Pop());
    
    Queue<String> li = new Queue<String>();//queue
    LinkedList<String> li = new LinkedList<String>();//linkedlist
    Dictionary<String> li = new Dictionary<String>();//dictionary - key value, unique
    SortedDictionary<String> li = new SortedDictionary<String>();//sorteddictionary - key value, unique, asc order
    SortedList<String> li = new SortedList<String>();//sortedlist - key value, unique, asc order, uses less memory than SortedDictionary
    foreach(string name in li){
        Console.WriteLine(name);
    }
  }
}


