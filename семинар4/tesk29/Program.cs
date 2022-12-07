//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран. Данные вводятся с консоли пользователем

 
 Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите второе  число");
int numberB = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите четвертое число");
int numberD = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите пятое число");
int numberF = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите шестое число");
int numberG = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите седьмое число");
int numberH = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите восьмое число");
int numberK = Convert.ToInt32(Console.ReadLine());
int [] array = new int [8];


for (int i = 1; i < 8; i++)
{
   array [i]=new Random().Next(numberA, numberK); 
}


Console.WriteLine($"[{string.Join(", ", array)}]");
