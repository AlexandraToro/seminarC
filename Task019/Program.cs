// Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Первый вариант решения с иcпользованием вычислений
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    if (num / 10000 == num % 10 && num / 1000 - (num / 10000) * 10 == (num % 100 - num % 10) / 10)
    {
        Console.WriteLine($"{num} -> Да");
    }
    else
    {
        Console.WriteLine($"{num} -> Нет");
    }
}
else
{
    Console.WriteLine("Ошибка. Введено некорректное значение.");
}

//Второй вариант решения через строковую переменную
Console.WriteLine("Введите пятизначное число");
string number = (Console.ReadLine());
if (number.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} -> Да");
    }
    else
    {
        Console.WriteLine($"{number} -> Нет");
    }
}
else
{
    Console.WriteLine("Ошибка. Введено некорректное значение.");
}
