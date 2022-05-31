// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите цифры через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int GetNumAboveZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int res = GetNumAboveZero(array);
Console.WriteLine($"Количество чисел больше 0 в равно: {res}");