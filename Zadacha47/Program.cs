// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака. m = 3, n = 4.
Console.WriteLine("введите число строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов");
int colum = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[line, colum];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

    void FillArrayRandomNumbers(double[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble(random.Next(-10, 10) + random.NextDouble());
            }
        }
    }

    void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(Math.Round(array[i, j],1) + " ");
            }
            Console.Write("]");
			Console.WriteLine();
           
        }
    }
    
