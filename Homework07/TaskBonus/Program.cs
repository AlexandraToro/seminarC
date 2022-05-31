// Задать целочисленный двумерный массив размерности n х m.
// Выяснить, в какой строке последовательность является возрастающей или убывающей.

int[,] GetArray(int a, int b)
{
    int[,] newAr = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < newAr.GetLength(0); i++)
    {
        for (int j = 0; j < newAr.GetLength(1); j++)
        {
            newAr[i, j] = rnd.Next(-100, 100);
        }
    }
    return newAr;
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

void IncreasesOrDecreasesRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        bool y = true;
        if (array[i, 0] > array[i, 1])
        {
            int j = 1;
            while (j < array.GetLength(1) - 1)
            {
                if (array[i, j] > array[i, j + 1]) y = true;
                else
                {
                    y = false;
                    break;
                }
                j++;
            }
            if (y == true) Console.WriteLine($"В строке {i + 1} убывающие значения");
        }
        y = true;
        if (array[i, 0] < array[i, 1])
        {
            int j = 1;
            while (j < array.GetLength(1) - 1)
            {
                if (array[i, j] < array[i, j + 1]) y = true;
                else
                {
                    y = false;
                    break;
                }
                j++;
            }
            if (y == true) Console.WriteLine($"В строке {i + 1} возрастающие значения");
        }
    }
}

/* Тут избыточный код с учетом анализа каждой строки и с учетом возможности равенства элементов.
void IncreasesOrDecreasesRows(int[,] array)
{
    string res = string.Empty;
    bool x;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i, 0] > array[i, 1])
        {
            int j = 1;
            while (j < array.GetLength(1) - 1)
            {
                if (array[i, j] > array[i, j + 1])
                {
                    res = $"В строке {i + 1} убывающие значения";
                }
                else
                {
                    res = $"В строке {i + 1} последовательности возрастания/убывания не определено";
                    break;
                }
                j++;
            }
            Console.WriteLine(res);
        }
        if (array[i, 0] < array[i, 1])
        {
            int j = 1;
            while (j < array.GetLength(1) - 1)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    res = $"В строке {i + 1} возрастающие значения";
                }
                else
                {
                    res = $"В строке {i + 1} последовательности возрастания/убывания не определено";
                    break;
                }
                j++;
            }
            Console.WriteLine(res);
        }
        if (array[i, 0] == array[i, 1])
        {
            res = $"В строке {i + 1} последовательности возрастания/убывания не определено";
            Console.WriteLine(res);
        }
    }
}*/

Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

int[,] arrayResult = GetArray(n, m);
Console.WriteLine("Сгенерированный массив:");
PrintArray(arrayResult);
IncreasesOrDecreasesRows(arrayResult);
Console.WriteLine();

int[,] arr1 = new int[,]
{{1,2,3,4},{15,10,9,8},{1,15,4,19}};
Console.WriteLine("Заданный массив для контрольной проверки:");
PrintArray(arr1);
IncreasesOrDecreasesRows(arr1);
