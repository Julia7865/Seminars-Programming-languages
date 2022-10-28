// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// {1, 9, 9, 0, 2, 8, 0, 9}    0 встречается 2 раза
//                             1 встречается 1 раз     
//                             2 встречается 1 раз
//                             8 встречается 1 раз
//                             9 встречается 3 раза


int[,] array2D = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int [] oneRowArray2D = MatrixToOneRowArray(array2D);
PrintArray(oneRowArray2D);
Array.Sort(oneRowArray2D);
PrintArray(oneRowArray2D);
HowManyNumbersInArray(oneRowArray2D);


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[] MatrixToOneRowArray(int[,] matrix)
{
    int[] oneRowArray = new int[matrix.Length];
    int counter = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            oneRowArray[counter] = matrix[i, j];
            counter++;
        }
    }    
    return oneRowArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void HowManyNumbersInArray(int[] array)
{
    int counter = 1;
    int numForCount = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(numForCount == array[i]) counter++;
        else
        {
            Console.WriteLine($"{numForCount} -> {counter}");
            numForCount = array[i];
            counter = 1;
        }
    }
    Console.WriteLine($"{numForCount} -> {counter}");
}





















