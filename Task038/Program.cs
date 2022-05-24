//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Random num = new Random();
int[] array = new int[num.Next(5, 10)];

int[] GetArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = num.Next(1, 100);
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

int GetMax(int[] arr3)
{
    int maxNum = arr3[0];
    for (int i = 1; i < arr3.Length; i++)
    {
        if (arr3[i] > maxNum) maxNum = arr3[i];
    }
    return maxNum;
}

int GetMin(int[] arr4)
{
    int minNum = arr4[0];
    for (int i = 1; i < arr4.Length; i++)
    {
        if (arr4[i] < minNum) minNum = arr4[i];
    }
    return minNum;
}

GetArray(array);
PrintArray(array);
Console.WriteLine();
//Console.WriteLine(GetMax(array));
//Console.WriteLine(GetMin(array));

Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {GetMax(array) - GetMin(array)}");