// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

Random num = new Random();
int[] array = new int[num.Next(1, 10)];

int[] GetArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = num.Next(100, 1000);
    }
    return arr1;
}

void PrintArray(int[] arr2)
{
    Console.WriteLine("Заданный массив: ");
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write(arr2[i] + " ");
    }
}

int GetEvenNum(int[] arr3)
{
    int res = 0;
    for (int i = 0; i < arr3.Length; i++)
    {
        if (arr3[i] % 2 == 0) res += 1;
    }
    return res;
}

GetArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных числе в массиве равно {GetEvenNum(array)}");