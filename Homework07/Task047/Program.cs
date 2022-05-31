// Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] GetArray(int a, int b)
{
    double[,] newAr = new double[a, b];
    Random rnd = new Random();
    for (int i = 0; i < newAr.GetLength(0); i++)
    {
        for (int j = 0; j < newAr.GetLength(1); j++)
        {
            newAr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
    return newAr;
}

void PrintArray(double[,] arr)
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

double[,] arrayResult = GetArray(m, n);
Console.WriteLine("Сгенерированный массив:");
PrintArray(arrayResult);
