// Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumber(int num)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
int result = SumNumber(number);
Console.WriteLine($"Сумма цифр числа {number} = {result}");


// Что нужно сделать, чтобы в ответе number был введенным число, 
// а не результатом вычислений?