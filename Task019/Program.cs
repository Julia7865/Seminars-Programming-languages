// Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 && number > 100000) Console.WriteLine("Введите правильное число");

void Palindrome(int num)
{
    int[] array = { number };
    int index = 0;
    int temp = 0;
    int size = array.Length;
    while (index < number)
    {
        temp = array[size - 1];
        array[size - 1] = array[index];
        array[index] = temp;
        array[size - 1] = array[size - index - 1];
        index++;
    }
}
Palindrome(number);
int result = Palindrome(number);
if (result == number) Console.WriteLine($"{number} является палиндромом");
else Console.WriteLine($"{number} Не является палиндромом");

// Не пойму, что сделать, чтобы заработало