using System;
namespace DataStructure267
{
	public class CustomeStack
	{
        Stack<int> stack = new Stack<int>();
        public void CustomeStackOperations()
		{
			stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
			Display();
            Console.WriteLine("To remove element");
            stack.Pop();
            Display();

            Console.WriteLine("The Top elemnt is " + stack.Peek());
            
            
        }

        public void Display()
        {
            foreach (int element in stack)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}

