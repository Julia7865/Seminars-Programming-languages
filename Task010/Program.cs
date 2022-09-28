// Напишите программу, 
// которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите  трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1000) Console.WriteLine("Введите правильное число");
else
{
    int ShowSecondDigit(int num)
    {
        int firstDigit = num / 100;
        return num / 10 - firstDigit * 10;
    }
    int result = ShowSecondDigit(number);
    Console.WriteLine($"Итоговое число от {number} -> {result}");
}



