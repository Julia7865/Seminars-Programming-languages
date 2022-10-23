// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет




void PrintElemByIndex(int[,] matrix)
{
    Console.WriteLine("Введите строку: ");
    int m = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine("Введите столбец: ");
    int n = Convert.ToInt32(Console.ReadLine()) - 1;
    if(m >= matrix.GetLength(0) || n >= matrix.GetLength(1)) Console.WriteLine("Такого элемента нет");
    else if(m < 0 || n < 0) Console.WriteLine("Такого элемента нет");
    else Console.WriteLine(matrix[m, n]);
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
PrintElemByIndex(array2D);





