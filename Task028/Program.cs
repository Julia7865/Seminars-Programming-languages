// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int result = Factorial(number);
    Console.WriteLine($"Произведение числа от 1 до {number} = {result}");
}
else Console.WriteLine("Введено некорректное значение");

int Factorial(int num)
{
    int multiplic = 1;
    for (int i = 1; i <= num; i++)
    {
        multiplic = multiplic * i;
    }
    return multiplic;
}











