using System;
using System.Xml.Linq;

namespace DataStructure267
{
	public class LinkedList<T>
	{
        public Node<T> head;

        internal void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is Inserted into Linked List", newNode.data);
        }
        public void AddFirst(T data)
        {

            Node<T> node = new Node<T>(data);
            node.next = this.head;
            this.head = node;
            Console.WriteLine("{0} is inserted into LikedList", node.data);
        }

        public void RemoveFist()
        {
            Node<T> temp = head;
            if (temp == null)
                Console.WriteLine("Its empty please add nodes");
            else
                Console.WriteLine("{0} is removed", head.data);
            head = head.next;
        }
        public void Search(T data)
        {
            bool isFound = false;
            Node<T> temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is Empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data.Equals(data))
                    {
                        Console.WriteLine("{0} node is presernt", temp.data);
                        isFound = true;
                        break;

                    }
                    temp = temp.next;

                }
                if (!isFound)
                    Console.WriteLine("{0} node is not present", data);
            }
        }

        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinked List is Empty ");
            }
            Console.WriteLine("\nDisplaying Nodes: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

