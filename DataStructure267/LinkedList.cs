using System;
using System.Collections;
using System.Collections.Generic;
namespace DataStructure267
{
	public class LinkedList
	{
        public static void LinkedListBuiltIn()
		{
			LinkedList<string> list = new LinkedList<string>();
            list.AddLast("Puneeth");
            list.AddLast("Abhishek");
            list.AddLast("Karthik");
            list.AddLast("Pavan");
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nRemove element");
			list.Remove("Karthik");
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nRemove first element");
            list.RemoveFirst();
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nRemove last element");
            list.RemoveLast();
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Search element");
            if (list.Contains("Puneeth"))
            {
                Console.WriteLine("Element is found");
            }
            else
            {
                Console.WriteLine("Element is Not found");
            }
        }
	}
}

