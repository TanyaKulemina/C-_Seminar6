/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int number = Convert.ToInt32(Console.ReadLine());

string number_str = "";

while (number > 0)
{
    number_str = number % 2 + number_str;
    number = number / 2;
}
Console.WriteLine(number_str);