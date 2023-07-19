// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMeanColumns(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];
    double arithmeticMean = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            arithmeticMean = arithmeticMean + matr[i, j];
        }
        arr[j] = Math.Round(arithmeticMean / matr.GetLength(0), 2);
        arithmeticMean = 0;
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

int[,] array2D = GetMatrix(rows, columns, 0, 100);
PrintMatrix(array2D);
Console.WriteLine();
PrintArray(ArithmeticMeanColumns(array2D));