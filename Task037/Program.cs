// /*Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве*/

Random num = new Random();
int[] array = new int[num.Next(5, 8)];

int[] GetArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = num.Next(2, 7);
    }
    return arr1;
}

void PrintArray(int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write(arr2[i] + " ");
    }
}

int size = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;     //определяем длину нового массива для записи данных

int[] arr = new int[size];

int[] GetMultArray(int[] arr4)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = arr4[i] * (arr4[arr4.Length - 1 - i]);
        //Console.WriteLine(arr[i]);
    }
    if (arr4.Length % 2 != 0) arr[size - 1] = arr4[arr4.Length / 2];              //при нечетном количестве необходимо заменить новое значение на исходное.
    //Console.WriteLine(arr[size-1]);
    return arr;
}

GetArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.WriteLine();
GetMultArray(array);
Console.Write("Массив с данными умножения элементов предыдущего массива: ");
PrintArray(arr);
