// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}


void PrintAndMinSumLine(int[,] matrix)
{

    int[] minSumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine($" |(сумма = {sum})");
        minSumArray[i] = sum;
    }
    Console.WriteLine();
    int minSum = minSumArray[0];
    int line = 0;
    for (int k = 0; k < minSumArray.Length; k++)
    {
        if (minSumArray[k] < minSum)
        {
            minSum = minSumArray[k];
            line = k;
        }

    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {line + 1}");
}

int m = new Random().Next(2, 7);
int n = new Random().Next(2, 7);
int[,] matrix = FillMatrix(m, n);

PrintAndMinSumLine(matrix);
