using System;
namespace Assignment03
{
	public class Color
	{
		private int red;
		private int green;
		private int blue;
		private int alpha;
		public Color(int r, int g, int b)
		{
			SetRed(r);
			SetGreen(g);
			SetBlue(b);
			SetAlpha(255);
		}

		public void SetRed(int n) {
			if (n > -1 && n < 256) red = n;
		}

        public int GetRed(int n)
        {
            return red;
        }

        public void SetGreen(int n)
        {
            if (n > -1 && n < 256) green = n;
        }

        public int GetGreen(int n)
        {
            return green;
        }

        public void SetBlue(int n)
        {
            if (n > -1 && n < 256) blue = n;
        }

        public int GetBlue(int n)
        {
            return blue;
        }

        public void SetAlpha(int n)
        {
            if (n > -1 && n < 256) alpha = n;
        }

        public int GetAlpha(int n)
        {
            return alpha;
        }

        public int GetGrayscale() {
            return (red + green + blue) / 3;
        }

    }
}

