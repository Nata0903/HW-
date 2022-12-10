//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Console.WriteLine("Введите пятизначное число ");
//int N = Convert.ToInt32(Console.ReadLine());

//if ( N<= 0)
//{
  //Console.WriteLine("Введите положительное число");  
//}
//else if (int.i0 == int.i4 && int.i1 == int.i3)
//{
  // Console.WriteLine("Число является палиндромом"); 
//}
//else 
//{
  //  Console.WriteLine(" Не палиндром");
//}

int[] a = {1 , 7, 3, 2, 1};
bool res = true;//res = true палиндром, res = false, то нет.

for (int i = 0; i < a.Length / 2; i ++)
{
  if (a[i] != a[a.Length - 1 -i])
  {
    res = false;
  }
}
Console.WriteLine(res);

