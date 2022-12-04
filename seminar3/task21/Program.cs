//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// l = √ (xb - xa) 2+ (yb - ya) 2+ (zb - za) 2

Console.WriteLine("Введите координаты Xa точки А");
double Xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Ya точки А");
double Ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Za точки А");
double Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Xb точки В");
double Xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Yb точки В");
double Yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Zb точки B");
double Zb = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow(Xb - Xa,2);
double resY = Math.Pow(Yb - Ya,2);
double resZ = Math.Pow(Zb - Za,2);

double res = Math.Sqrt(resX + resY + resZ);
Console.WriteLine($"{res:f2}");


