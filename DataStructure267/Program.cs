using System.Collections.Generic;
using DataStructure267;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure");
        Console.WriteLine("Choose an option");
        Console.WriteLine("\n1:Custome LinkedList\n2:Custome Stack\n3:Custom Queue");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                DataStructure267.LinkedList<int> linkedList = new DataStructure267.LinkedList<int>();
                linkedList.Add(50);
                linkedList.Add(70);
                linkedList.AddFirst(40);
                linkedList.Display();
                linkedList.RemoveFist();
                linkedList.Search(70);
                linkedList.Display();
                DataStructure267.LinkedList<string> linkedList1 = new DataStructure267.LinkedList<string>();
                Console.WriteLine("\n -------------------------------");
                linkedList1.Add("puneeth");
                linkedList1.Add("Abhi");
                linkedList1.AddFirst("Karthik");
                linkedList1.RemoveFist();
                linkedList1.Search("Abhi");
                linkedList1.Display();
                break;

            case 2:
                CustomStack<int> customStack = new CustomStack<int>();
                customStack.Push(50);
                customStack.Push(70);
                customStack.Push(40);
                customStack.Peek();
                customStack.Pop();
                customStack.Display();
                Console.WriteLine("\n---------------------------------------------");
                CustomStack<string> customStack1 = new CustomStack<string>();
                customStack1.Push("Apple");
                customStack1.Push("Mango");
                customStack1.Push("Orange");
                customStack1.Peek();
                customStack1.Pop();
                customStack1.Display();
                break;

            case 3:
                CustomeQueue<int> customeQueue = new CustomeQueue<int>();
                customeQueue.Enqueue(10);
                customeQueue.Enqueue(20);
                customeQueue.Enqueue(30);
                customeQueue.Display();
                customeQueue.Dequeue();
                break;
        }
        Console.ReadLine();
    }
}