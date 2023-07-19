// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Искомое число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());

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

void FindNumber(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == findNumber)
            {
                Console.WriteLine($"Число {findNumber} есть в массиве");
                return;
            }
            else
            {
                if (matr[i, j] == matr[matr.GetLength(0) - 1, matr.GetLength(1) - 1] && matr[i, j] != findNumber)
                {
                    Console.WriteLine($"Числа {findNumber} нет в массиве");
                    return;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}


int[,] array2D = GetMatrix(rows, columns, 0, 100);
PrintMatrix(array2D);
FindNumber(array2D);