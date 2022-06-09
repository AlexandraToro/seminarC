/* Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */


int[,] GetRandMatrix()
{
    Random rnd = new Random();
    int[,] matr = new int[4, 4];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetMultiplicMatrix(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
        int[,] newMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
        int sum = 0;
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int k = 0; k < matr2.GetLength(1); k++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    sum = sum + (matr1[i, j] * matr2[j, k]);
                    //Console.WriteLine($" сумма {matr1[i, j]} * {matr2[j, k]}= {sum}");
                }
                newMatr[i, k] = sum;
                sum = 0;
            }
        }
        Console.WriteLine("Результат произведения матриц:");
        PrintMatrix(newMatr);
    }
    else Console.WriteLine("Ошибка. Умножить две матрицы можно лишь в случае, если число столбцов первой матрицы равняется числу строк второй."); ;
}


int[,] arr1 = GetRandMatrix();
Console.WriteLine("Первая матрица:");
PrintMatrix(arr1);
int[,] arr2 = GetRandMatrix();
Console.WriteLine("Вторая матрица:");
PrintMatrix(arr2);
GetMultiplicMatrix(arr1, arr2);
Console.WriteLine();

Console.WriteLine("Для контролируемой проверки с заданными матрицами:");
int[,] arr3 = new int[,] { { 2, 0, -1 }, { 0, -2, 2 } };
Console.WriteLine("Первая матрица:");
PrintMatrix(arr3);
int[,] arr4 = new int[,] { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };
Console.WriteLine("Вторая матрица:");
PrintMatrix(arr4);
GetMultiplicMatrix(arr3, arr4);
