// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
try
{
Console.WriteLine("Введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Расстояние между двумя точками " + DistanceCalc(x1, y1, z1, x2, y2, z2));
}
catch
{
   Console.WriteLine("Введены некорректные данные"); 
}




double DistanceCalc (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result1 = (x2 - x1) * (x2 - x1);
    double result2 = (y2 - y1) * (y2 - y1);
    double result3 = (z2 - z1) * (z2 - z1);
    double result = Math.Sqrt(result1 + result2 + result3);
    return result;
}