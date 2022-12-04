// Задача 17. Напишите программу, которая принимает на вход координаты точки (Х,У),
// причем х=/0 у =/ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты по Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты по у");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (x < 0 && y > 0)
{
  Console.WriteLine("Точка находится во второй  четверти");  
}
else if ( x < 0 && y < 0 )
{
 Console.WriteLine("Точка находится в третьей четверти"); 
}
else if ( x > 0 && y < 0 )
{
Console.WriteLine("Точка находится в четвёртой четверти"); 
}
else 
{
  Console.WriteLine("Невозможно определить координатную четверть");  
}