// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
Console.WriteLine("Данная прорамма находит точку пересечений двух прямых через заданные значения");
Console.WriteLine("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine());

void GetCoorXY(int a1, int a2, int c1, int c2)
{
    int x = 0;
    int y = 0;
    x = (c2 - c1) / (a1 - a2);
    y = a1 * x + c1;
    Console.WriteLine($"Точка пересесения данных прямых ({x};{y})");
}
GetCoorXY(b1, b2, k1, k2);