// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}

int sumElemFromMToN = SumElemFromMToN(numberM, numberN);
Console.WriteLine($"{sumElemFromMToN}");



int SumElemFromMToN(int numM, int numN)
{
    if(numM < numN) numM += SumElemFromMToN(numM + 1, numN);
    return numM;
}












