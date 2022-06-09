/* Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */

int[,,] GetRandomArray()
{
    Random rnd = new Random();
    int[,,] arr = new int[rnd.Next(3, 6), rnd.Next(4, 6), rnd.Next(2, 4)];
    int num = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = 10 + num;
                num++;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Строка номер {i+1}: ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
                    for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k}) |");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array = GetRandomArray();
PrintArray(array);
