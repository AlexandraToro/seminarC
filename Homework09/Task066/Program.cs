// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int SumNum(int a, int b)
{
    return a == b ? a : a + SumNum(a + 1, b);
}

if (m < n) Console.WriteLine($"Сумма натуральных чисел в заданном промежутке равна {SumNum(m, n)}");
else Console.WriteLine($"Сумма натуральных чисел в заданном промежутке равна {SumNum(n, m)}");