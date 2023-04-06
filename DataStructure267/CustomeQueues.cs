using System;
namespace DataStructure267
{
	public class CustomeQueues
	{
		Queue<string> queue = new Queue<string>();
		public void CustomQueues()
		{
			queue.Enqueue("Apple");
            queue.Enqueue("Mango");
            queue.Enqueue("Orange");
            queue.Enqueue("Pinepple");
			Display();

			queue.Dequeue();
			Display();
        }

		public void Display()
		{
			foreach(string element in queue)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();
		}
	}
}

