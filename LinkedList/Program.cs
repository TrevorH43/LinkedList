// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using LinkedList;

LinkedList ll = new LinkedList();
ll.Insert(44);
ll.Print();
ll.Insert(88);
ll.Print();
ll.Insert(33);
ll.Print();
ll.Insert(66);
ll.Print();

ll.Delete(88);
Console.WriteLine("After Delete...");
ll.Print();
int noOfNodes = ll.Count();
Console.WriteLine($"list contains returns {noOfNodes} nodes");

Console.WriteLine($"list found(88) = {ll.Find(88)}");
Console.WriteLine($"list found(44) = {ll.Find(44)}");

Console.WriteLine("Linked List before clear contains:");
ll.Print();
ll.Clear();
Console.WriteLine("Linked List after clear contains:");
ll.Print();