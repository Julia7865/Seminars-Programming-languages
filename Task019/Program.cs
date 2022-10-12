// Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 && number > 100000) Console.WriteLine("Введите правильное число");
int a1 = number % 10;
int a2 = number / 10 % 10;
int a3 = number / 100 % 10;
int a4 = number / 1000 % 10;
int a5 = number / 10000;
if (a1 == a5 && a2 == a4) Console.WriteLine($"{number} является палиндромом");
else Console.WriteLine($"{number} НЕ является палиндромом");




// void Palindrome(int num)
// {
//     int[] array = { number };
//     int index = 0;
//     int temp = 0;
//     int size = array.Length;
//     while (index < number)
//     {
//         temp = array[size - 1];
//         array[size - 1] = array[index];
//         array[index] = temp;
//         array[size - 1] = array[size - index - 1];
//         index++;
//     }
// }
// Palindrome(number);
// int result = Palindrome(number);
// if (result == number) Console.WriteLine($"{number} является палиндромом");
// else Console.WriteLine($"{number} Не является палиндромом");

// Не пойму, что сделать, чтобы заработало