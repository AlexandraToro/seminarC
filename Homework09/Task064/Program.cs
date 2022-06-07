/* Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

Console.WriteLine("Введите натуральное число M: ");
int numM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numN = int.Parse(Console.ReadLine());

void PrintNaturalNum(int m, int n)
{
    if (n < m) return;
    PrintNaturalNum(m, (n - 1));
    Console.Write($"{n} ");
}

if (numN == numM) Console.Write($"{numN} ");
else if (numN > numM) PrintNaturalNum(numM, numN);
else PrintNaturalNum(numN, numM);


/*void PrintNaturalNum(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{n} ");
        return;
    }
    else if (m < n)
    {
        if (n < m)
            return;
        PrintNaturalNum(m, (n - 1));
        Console.Write($"{n} ");
    }
    else
    {
        if (m < n)
            return;
        PrintNaturalNum(m - 1, n);
        Console.Write($"{m} ");
    }

}
PrintNaturalNum(numM, numN);*/
