// Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите любое число А: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите любое натуральное число В: ");
int numB = int.Parse(Console.ReadLine());

int GetPow(int num1, int num2)
{
    int res = 1;
    for (int i = 1; i <= num2; i++)
    {
        res = res * num1;
    }
    return res;
}

int result = GetPow(numA, numB);
Console.WriteLine($"{numA} в степени {numB} равно {result}");
