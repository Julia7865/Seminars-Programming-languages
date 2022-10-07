//  Напишите программу, 
//  которая выводит третью цифру заданного числа или 
//  сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");
while (number > 100)
{
    int number1 = number / 10;
    number++;
}
int res = number % 10; 
Console.WriteLine($"{res}");


// Не получилось