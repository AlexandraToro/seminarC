//Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите значение хА = ");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение yA = ");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение zA = ");
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение xB = ");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение уВ = ");
int yB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение zB= ");
int zB = int.Parse(Console.ReadLine());

float getDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    float res = (float)(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
    return res;
}
Console.Write($"A ({xA},{yA},{zA}); B ({xB},{yB},{zB}) - > ");
Console.WriteLine("{0: 0.00}", getDistance(xA, yA, zA, xB, yB, zB));