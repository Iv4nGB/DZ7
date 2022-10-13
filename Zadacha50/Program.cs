// Zadacha50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[10, 10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
	Console.WriteLine("такого элемента нет");
}
else
{
	Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
	Random random = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.Next(-10, 10);
		}
	}
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		Console.Write("[ ");
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + "\t");
		}
		Console.Write("]");
		Console.WriteLine("");
	}
}
