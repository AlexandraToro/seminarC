/* Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

int[,] GetRandomArray()
{
    Random rnd = new Random();
    int[,] arr = new int[rnd.Next(3, 6), rnd.Next(4, 6)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0,10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindRowOfMinSum(int[,] arr)
{
    int sum = 0;
    int[] newArr = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        //Console.WriteLine(sum); - можно использовать для визуальной проверки работы программы
        newArr[i] = sum;
        sum = 0;
    }
    int minIndex = 0;
    for (int i = 1; i < newArr.Length; i++)
    {
        if (newArr[i] < newArr[minIndex]) minIndex = i;
    }
    return (minIndex + 1);
}

int[,] array = GetRandomArray();
PrintArray(array);
int min = FindRowOfMinSum(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min}");
