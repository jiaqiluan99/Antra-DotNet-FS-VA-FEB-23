	using System;
namespace Assignment03
{
	public class Ball
	{
		private int size;
		private Color color;
		private int thrown;
		public Ball(int s, Color c, int t)
		{
			size = s;
			color = c;
			thrown = t;
		}

		public Ball(int s, Color c) : this(s, c, 0) { }

		public Ball(Color c) : this(0, c, 0) { }

		public void Pop() {
			size = 0;
		}

		public void Throw() {
			if (size > 0) thrown++;
        }

		public int TimesThrown() {
			return thrown;
		}

		public Color GetColor() {
			return color;
		}

		public int GetSize() {
			return size;
		}
	}
}

