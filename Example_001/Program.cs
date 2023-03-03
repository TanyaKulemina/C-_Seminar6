/* 
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/


//метод заполняющий заданный массив рандомными числами 
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

//метод выводящий массив в консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//метод переворачивающий массив
int[] Converse(int[] arr)
{
    int length = arr.Length;
    int[] arrNew = new int[arr.Length];

    for (int i = 0; i < length; i++)
    {
        arrNew[i] = arr[length - 1 - i];
    }

    return arrNew;
}

int[] array = new int[4];
FillArray(array);
PrintArray(array);
int[] arrayNew = Converse(array);
Console.WriteLine();
PrintArray(arrayNew);