// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 Random rand = new Random();
Console.Write("Введите координату X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
//int x1 = rand.Next(0,100);
//int y1 = rand.Next(0,100);
//int z1 = rand.Next(0,100);
//Console.WriteLine($"Координаты точки А:({x1}, {y1}, {z1})");

Console.Write("Введите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//int x2 = rand.Next(0,100);
//int y2 = rand.Next(0,100);
//int z2 = rand.Next(0,100);
//Console.WriteLine($"Координаты точки В:({x2}, {y2}, {z2})");

double dist = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
Console.Write($"Расстояние между точками А:({x1}, {y1}, {z1}) и И В:({x2}, {y2}, {z2}) = {dist:f2}");