using System;
namespace Assignment04
{
	public class MyStack<T>
	{
		private class Node {
			private Node prev = null;
			private T value;
			public Node(T val, Node p) {
				value = val;
				prev = p;
			}
			public Node GetPrev() {
				return prev;
			}
			public T GetValue() {
				return value;
			}
		}

		private Node top;
		private int count;

		public MyStack()
		{
			top = null;
			count = 0;
		}

		public int Count() {
			return count;
		}

		public T Pop() {
			if (count < 1)
			{
				Console.WriteLine("The Stack is empty!");
				return default(T);
			}
			T result = top.GetValue();
			top = top.GetPrev();
			count--;
			return result;
		}

		public void Push(T val) {
			Node node = new(val, top);
			top = node;
			count++;
		}

    }
}

