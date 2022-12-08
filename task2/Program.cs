// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними 
// в 3D пространстве.

Console.WriteLine("Введите координату х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между точками " + Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)));