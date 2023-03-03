/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
        }
    }
    return resultNumber;
}

double b1 = GetNumber("Введите число b1");
double k1 = GetNumber("Введите число k1");
double b2 = GetNumber("Введите число b2");
double k2 = GetNumber("Введите число k2");

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"{x}, {y}");


