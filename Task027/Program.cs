// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите любое натуральное число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр числа {num} равна {(GetSumNum(num))}");
