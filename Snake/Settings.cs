using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	public enum Direction
	{
		Up,
		Down,
		Left,
		Right
	};
	class Settings
	{
		public static int Width{get; set;}
		public static int Height { get; set; }
		public static int Speed { get; set; }
		public static int Score { get; set; }
		public static int Point { get; set; }
		public static bool GameOver { get; set; }
		public static Direction direction { get; set; }

		public Settings()
		{
			Width = 16;
			Height = 16;
			Speed = 10;
			Score = 0;
			Point = 100;
			GameOver = false;
			direction = Direction.Down;
		}
	}
}
