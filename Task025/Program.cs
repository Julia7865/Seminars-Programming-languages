﻿// Напишите цикл, 
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int Degree(int num)
{
    int degree = 1;
    int counter = 1;
    while (counter <= number2)
    {
        degree = degree * number1;
        counter++;
    }
    return degree;
}
int degreeResult = Degree(number1);
Console.WriteLine($"{number1} в степени {number2} = {degreeResult}");

