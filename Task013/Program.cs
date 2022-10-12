//  Напишите программу, 
//  которая выводит третью цифру заданного числа или 
//  сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");
int ThirdNumber(int num)
{
    int result = 1;
    while (number > 99)
    {
        result = number % 10;
        number = number / 10;
    }
    return result;
}
Console.WriteLine(ThirdNumber(number));
