internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write("Введите координаты Коня - 2 числа от 1 до 8 через пробел: ");
		int[]? massСhessKnight = TestInput();
		if (massСhessKnight[0] == 0 || massСhessKnight[1] == 0)
		{
			Console.WriteLine("Задача завершена");
		}
		else
		{
			Console.Write("Введите координаты Шахматной фигуры - 2 числа от 1 до 8 через пробел: ");
			int[]? massОfaChessPiece = TestInput();
			if (massОfaChessPiece[0] == 0 || massОfaChessPiece[1] == 0)
			{
				Console.WriteLine("Задача завершена");
			}
			else
			{
				if (((massОfaChessPiece[0] == massСhessKnight[0] + 1 || massОfaChessPiece[0] == massСhessKnight[0] - 1)
												 && (massОfaChessPiece[1] == massСhessKnight[1] - 2 || massОfaChessPiece[1] == massСhessKnight[1] + 2))
												 || ((massОfaChessPiece[0] == massСhessKnight[0] - 2 || massОfaChessPiece[0] == massСhessKnight[0] + 2)
												 && (massОfaChessPiece[1] == massСhessKnight[1] - 1 || massОfaChessPiece[1] == massСhessKnight[1] + 1)))
				{
					Console.WriteLine("YES");
				}
				else
				{
					Console.WriteLine("NO");
				}
			}

		}
	}
	private static int[] TestInput()
	{
		int[] massInput = { 0, 0 };
		string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

		if (elements.Length == 0 || elements.Length == 1)
		{
			Console.WriteLine("Недостаточно данных для определения местоположения Шахматной фигуры");
		}
		else
		{
			if (elements.Length > 2)
			{
				Console.WriteLine("Слишком много данных");
			}
			else
			{
				massInput = new int[elements.Length];
				for (int i = 0; i < elements.Length; i++)
				{
					bool isParsed = int.TryParse(elements[i], out massInput[i]);
					if (isParsed == false)
					{
						Console.WriteLine("Введено некорректное значение в элементе " + i);
						break;
					}
					if (massInput[i] < 1 || massInput[i] > 8)
					{
						Console.WriteLine("Введенная координата вне шахматного поля");
						massInput[i] = 0;
						break;
					}
				}
				return massInput;

			}
			return massInput;

		}
		return massInput;

	}
}