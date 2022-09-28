// Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7) Console.WriteLine("Введите правильное число");
if (num == 1) Console.WriteLine("НЕТ");
if (num == 2) Console.WriteLine("НЕТ");
if (num == 3) Console.WriteLine("НЕТ");
if (num == 4) Console.WriteLine("НЕТ");
if (num == 5) Console.WriteLine("НЕТ");
if (num == 6) Console.WriteLine("ДА");
if (num == 7) Console.WriteLine("ДА");



