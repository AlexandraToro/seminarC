/* Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
 */

int[,] GetRandomArray()
{
    Random rnd = new Random();
    int[,] arr = new int[rnd.Next(3, 5), rnd.Next(4, 6)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 100);
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

int[,] SortRowsArray(int[,] arr, int start, int end)
{
    if (arr.GetLength(1)<2) return arr;
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        int i = start;
        int j = end;
        int mediana = arr[k, ((start+end) / 2)];
        while (i <= j)
        {
            int temp = 0;
            while (arr[k, i] > mediana) i++;
            while (arr[k, j] < mediana) j--;
            if (i <= j)
            {
                temp = arr[k, i];
                arr[k, i] = arr[k, j];
                arr[k, j] = temp;
                i++;
                j--;
            }
        }
        if (i < end)
            SortRowsArray(arr, i, end);
        if (start < j)
            SortRowsArray(arr, start, j);
    }
    return arr;
}


int[,] array = GetRandomArray();
PrintArray(array);
int[,] newArray = SortRowsArray(array, 0, (array.GetLength(1) - 1));
Console.WriteLine();
PrintArray(newArray);

