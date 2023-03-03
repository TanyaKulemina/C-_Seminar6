/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
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

void Fibonachi(int number)
{
    if (number == 1) 
    {
        Console.WriteLine("0");
    }
    if (number == 2)
    {
        Console.WriteLine("0 1");
    }
    if (number > 2)
    {
        int[] fibArray = new int[number];
        fibArray[0] = 0;
        fibArray[1] = 1;
        for (int i = 2; i < number; i++)
        {
            fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
        }
        for (int i = 0; i < fibArray.Length; i++)
        {
            Console.Write($"{fibArray[i]} ");
        }
    }
}

int number = GetNumber("Введите число");
Fibonachi(number);
