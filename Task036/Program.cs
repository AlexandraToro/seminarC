// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Random num = new Random();
int[] array = new int[num.Next(3, 10)];

int[] GetArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = num.Next(1, 20);
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

int SumOddIndex(int[] arr3)
{
    int sum = 0;
    for (int i = 0; i < arr3.Length; i++)
    {
        if (i % 2 != 0) sum += arr3[i];
    }
    return sum;
}

GetArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {SumOddIndex(array)}");