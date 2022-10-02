//  Напишите программу, 
//  которая выводит третью цифру заданного числа или 
//  сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 10 == 0) Console.WriteLine("Третьей цифры нет");
int count = 1;
while (count < number)
{
    if (number / 10 > 100)
    {
        int number2 = number % 10;
        Console.WriteLine("{number2}");
    }
    count++;
}

// Не получилось