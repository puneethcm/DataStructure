using System;
using System.Xml.Linq;

namespace DataStructure267
{
	public class CustomeQueue<T>
	{
        public Node<T> head;

        public void Enqueue(T data)
        {
            Node<T> new_node = new Node<T>(data);
            if (head == null)
            {
                head = new_node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queues is Empty");
            }
            else
            {
                Node<T> temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Console.WriteLine("\n{0} is dequeus", temp.next.data);
                temp.next = null;
            }
        }
        public void Display()
        {
            Node<T> temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nStack is Empty");
            }
            else
            {
                Console.WriteLine("\nDisplaying the Nodes");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}

