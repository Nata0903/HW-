//Задача 20: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// A = ^( xb - xa) 2 + ( yb - ya )2 

Console.WriteLine("Введите координаты  точки Xa");
double Xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Ya");
double Ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Xb");
double Xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Yb");
double Yb = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow(Xb - Xa,2);
double resY = Math.Pow(Yb - Ya,2);
double res = Math.Sqrt(resX + resY);
Console.WriteLine($"{res:f2}");







