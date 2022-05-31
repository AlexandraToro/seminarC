/* Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

void GetColumnAverage(int[,] arr)
{
    float sum = 0;
    float sumAverage = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
        }
        sumAverage = sum/arr.GetLength(0);
        Console.Write("{0:0.0 }", sumAverage);
        sum = 0;
    }
}
int[,] array = GetArray();
Console.WriteLine("Сгенерированный массив:");
PrintArray(array);
Console.WriteLine("Среднее арифметическое значение в каждом столбце равно:");
GetColumnAverage(array);