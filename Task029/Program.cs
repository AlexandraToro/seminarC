//Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
//Размер массива определяется пользователем.

Console.WriteLine("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];

void GetArray(int[] arr1)
{
    int i = 0;
    while (i < arr1.Length)
    {
        arr1[i] = new Random().Next(0, 100);
        i++;
    }
    //return arr1;
}
void PrintArray(int[] arr2)
{
    for (int count = 0; count < arr2.Length; count++)
    {
        Console.Write($"{arr2[count]} ");
    }
}
GetArray(array);
PrintArray(array);