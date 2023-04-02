using System.Collections.Generic;
using DataStructure267;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure");
        DataStructure267.CustomeLinkedList<int> linkedList = new DataStructure267.CustomeLinkedList<int>();
        linkedList.Add(50);
        linkedList.Add(70);
        linkedList.AddFirst(40);
        linkedList.Display();
        linkedList.RemoveFist();
        linkedList.Search(70);
        linkedList.Display();
        DataStructure267.CustomeLinkedList<string> linkedList1 = new DataStructure267.CustomeLinkedList<string>();
        Console.WriteLine("\n -------------------------------");
        linkedList1.Add("puneeth");
        linkedList1.Add("Abhi");
        linkedList1.AddFirst("Karthik");
        linkedList1.RemoveFist();
        linkedList1.Search("Abhi");
        linkedList1.Display();
        Console.ReadLine();
    }
}