using System;
namespace Assignment03
{
	public static class PlayBalls
	{
		public static void run() {
			Color bk = new Color(0, 0, 0);
			Ball b1 = new Ball(10, bk);
			Console.WriteLine($"This is a size {b1.GetSize()} rgb {b1.GetColor().GetGrayscale()} ball that has been thrown {b1.TimesThrown()} times.");
			for (int i = 0; i < 20; i++) {
				if (i == 15) {
					b1.Pop();
                    Console.WriteLine($"Now the ball is popped and its size is now {b1.GetSize()}");
                }
				b1.Throw();
                Console.WriteLine($"This ball has been thrown {b1.TimesThrown()} times.");
            }

        }
	}
}

