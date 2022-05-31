/*Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.*/


int[,] GetArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
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

string SearchNum(int num1, int num2, int[,] arr)
{
    string res = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == num1-1 && j == num2-1)             // !!Программа написана с учетом нумерации строк с 1, а не с 0.
            {
                res = $"В данной позиции находится число {arr[i, j]}";
                return res;
            }
            else
            {
                res = "Такого элемента нет";
            }
        }
    }
    return res;
}

Console.WriteLine("Введите номер строки: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int b = int.Parse(Console.ReadLine());

int[,] array = GetArray();
PrintArray(array);
Console.WriteLine(SearchNum(a, b, array));