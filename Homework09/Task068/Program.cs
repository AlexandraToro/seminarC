// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите положительное число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите положительное число N: ");
int n = int.Parse(Console.ReadLine());

int FunctionAkcerman(int a, int b)
{
    if (a == 0) return (b + 1);
    if (a > 0 && b == 0) return (FunctionAkcerman((a - 1), 1));
    if (a > 0 && b > 0) return (FunctionAkcerman((a - 1), FunctionAkcerman(a, (b - 1))));
    else return 0;
}

int res = FunctionAkcerman(m, n);
if (res == 0) Console.WriteLine("Введены неправильные значения");
else Console.WriteLine($"Результат вычислений функции Аккермана равен {res}.");
