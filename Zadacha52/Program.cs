// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
	double avarage = 0;
	for (int i = 0; i < numbers.GetLength(0); i++)
	{
		avarage = (avarage + numbers[i, j]);
	}
	avarage = avarage / n;
	Console.Write(avarage + "; " + "\t");
}


void FillArrayRandomNumbers(int[,] array)
{
	Random random = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.Next(0, 100);
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

