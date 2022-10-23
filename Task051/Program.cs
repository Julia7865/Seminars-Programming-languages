// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  // rows(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // columns(1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

int SumMainDiagonal(int[,] matrix)
{
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j) sum = sum + matrix[i,j];
        }
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
int sumMainDiagonal = SumMainDiagonal(array2D);
Console.WriteLine($"Сумма элементов главное диагонали = {sumMainDiagonal}");

// int[,] myArray = CreateMatrix(4, 3, 1, 9);
// PrintMatrix(myArray);
// Console.WriteLine();
// Console.WriteLine($"{SummOfEqualIndex(myArray)}");


// int SummOfEqualIndex(int[,] matrix)
// {
// int sum = default;
// int targetSize = 0;
// if ( matrix.GetLength(0) > matrix.GetLength(1)) targetSize = 1;
// for (int i = 0; i < matrix.GetLength(targetSize); i++)
// {
// sum += matrix[i, i];
// }
// return sum;
// }












