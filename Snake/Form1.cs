using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
	public partial class Form1 : Form
	{
		private List<Circle> Snake = new List<Circle>();
		private Circle food = new Circle();
		public Form1()
		{
			InitializeComponent();
			new Settings();
			gameTimer.Interval = 1000/Settings.Speed;
			gameTimer.Tick += UpdateScreen;
			gameTimer.Start();

			StartGame();
		}

		private void StartGame()
		{
			lblGameOver.Visible = false;

			new Settings();

			Snake.Clear();
			Circle head = new Circle { X = 10, Y = 10 };
			Snake.Add(head);
			lblScore.Text = Settings.Score.ToString();
			GenerateFood();
		}

		public void GenerateFood()
		{
			int maxXPos = pbCanvas.Size.Width / Settings.Width;
			int maxYPos = pbCanvas.Size.Height / Settings.Height;

			Random random = new Random();

			food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
		}
		private void UpdateScreen(object sender , EventArgs e)
		{
			if (Settings.GameOver)
			{
				if (Input.KeyPressed(Keys.Enter))
				{
					StartGame();
				}
			}
			else
			{
				if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
				{
					Settings.direction = Direction.Right;
				}
				else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
				{
					Settings.direction = Direction.Left;
				}
				else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
				{
					Settings.direction = Direction.Up;
				}
				else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
				{
					Settings.direction = Direction.Down;
				}
				MovePlayer();
			}

			pbCanvas.Invalidate();
		}

		private void pbCanvas_Paint(object sender, PaintEventArgs e)
		{
			Graphics canvas = e.Graphics;

			if (!Settings.GameOver)
			{
				for (int i = 0; i < Snake.Count; i++)
				{
					Brush snakeColour;
					if (i == 0)
					{
						snakeColour = Brushes.Green;
					}
					else
					{
						if (i % 2 != 0)
						{
							snakeColour = Brushes.Red;
						}
						else
						{
							snakeColour = Brushes.Black;
						}
					}

					canvas.FillEllipse(snakeColour, new Rectangle(Snake[i].X * Settings.Width,
																   Snake[i].Y * Settings.Height,
																   Settings.Width, Settings.Height));

					canvas.FillEllipse(Brushes.Gold, new Rectangle(food.X * Settings.Width,
																 food.Y * Settings.Height,
																 Settings.Width, Settings.Height));
				}
			}
			else
			{
				string gameOver = "       Game Over !!! \nSeu Placar Final é = "+Settings.Score+"\nPressione Enter Para\n Tentar Novamente";

				lblGameOver.Text = gameOver;
				lblGameOver.Visible = true;
			}
		}
		public void MovePlayer()
		{
			for (int i = Snake.Count -1; i >= 0; i-- )
			{
				if (i == 0)
				{
					switch (Settings.direction)
					{
						case Direction.Right:
							{
								Snake[i].X++;
								break;
							}
						case Direction.Left:
							{
								Snake[i].X--;
								break;
							}
						case Direction.Up:
							{
								Snake[i].Y--;
								break;
							}
						case Direction.Down:
							{
								Snake[i].Y++;
								break;
							}
					}

							int maxXPos = pbCanvas.Size.Width / Settings.Width;
							int maxYPos = pbCanvas.Size.Height / Settings.Height;

							if (Snake[i].X < 0 || Snake[i].Y < 0||Snake[i].X>=maxXPos|| Snake[i].Y >= maxYPos)
							{
								Die();
							}
							for (int j = 1; j < Snake.Count; j++)
							{
								if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
								{
									Die();
								}
							}

					if (Snake[0].X == food.X && Snake[0].Y == food.Y)
							{
						Eat();
							}

					
				}
				else
				{
					Snake[i].X = Snake[i - 1].X;
					Snake[i].Y = Snake[i - 1].Y;
				}

			}

		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			Input.ChangeState(e.KeyCode,false);
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			Input.ChangeState(e.KeyCode, true);
		}

		private void Eat()
		{
			Circle circle = new Circle { X = Snake[Snake.Count - 1].X,
				                         Y = Snake[Snake.Count - 1].Y
			};
			Snake.Add(circle);

			Settings.Score += Settings.Point;
			lblScore.Text = Settings.Score.ToString();
			GenerateFood();
		}
		private void Die()
		{

			Settings.GameOver = true;
		}
	}
}
