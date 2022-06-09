void FillMatrixSpiral()
{
    Console.WriteLine("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    int[,] matr = new int[n, m];

    int i = 0; int j = 0; int count = 1;
    int iStart = 0; int jStart = 0; int iEnd = 0; int jEnd = 0;

    while (count <= n * m)
    {
        matr[i, j] = count;
        if (i == iStart && j < m - 1 - jEnd) j++;
        else if (j == m - 1 - jEnd && i < n - 1 - iEnd) i++;
        else if (i == n - 1 - iEnd && j > jStart) j--;
        else i--;
        if (i == iStart + 1 && j == jStart && jStart != m - 1 - jStart)
        {
            iStart++;
            iEnd++;
            jStart++;
            jEnd++;
        }
        count++;
    }
    Console.WriteLine("Спиральное заполнение заданного массива:");
    PrintMatrix(matr);
}
FillMatrixSpiral();

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10) Console.Write("0");
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}