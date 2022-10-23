// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3



Console.WriteLine("Сколько чисел вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите числа: ");
int numbers = Convert.ToInt32(Console.ReadLine());
// int[] numbers;



int SearchPositiveNum(int[] num)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (num[i] > 0) count++;
    }
    return count;
}

int searchPositiveNum = SearchPositiveNum(numbers);
Console.WriteLine(searchPositiveNum);


// Не понимаю как сделать ввод массива с клавиатуры

