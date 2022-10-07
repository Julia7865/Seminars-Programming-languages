// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());


// string QuarterStr(int quarter)
// {
//     if (quarter == 1) return "x > 0 y > 0";
//     if (quarter == 2) return "x < 0 y > 0";
//     if (quarter == 3) return "x < 0 y < 0";
//     if (quarter == 4) return "x > 0 y < 0";
//     return "Введены некорректные координаты";
// }
// string result = QuarterStr(quarter);
// Console.WriteLine(result);

void Range(int quarter2)
{
    if (quarter2 == 1) Console.WriteLine ("x > 0, y > 0");
    else if (quarter2 == 2) Console.WriteLine ("x < 0, y > 0");
    else if (quarter2 == 3) Console.WriteLine ("x < 0, y < 0");
    else if (quarter2 == 4) Console.WriteLine ("x > 0, y < 0");
    else Console.WriteLine("Введены некорректные данные"); 
}
Range(quarter);

