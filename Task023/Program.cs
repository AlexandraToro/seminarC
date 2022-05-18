// Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N = ");
int num = int.Parse(Console.ReadLine());

void numCube(int number)
{
Console.WriteLine("|{0,10}|{1,13}|", "Число", "Куб числа");
for(int i=1; i<=number; i++)
{
    Console.WriteLine("|{0,10}|{1,13}|", i, i*i*i);
}
}

numCube(num);

