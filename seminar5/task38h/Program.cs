//Задача 38: Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GetRandomArray(int size, int leftRange, int rightRange) 
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++ )
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}   
const int SIZE =5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(",", arr));

int res = 0;
int arr[i] = max;
int ar[i] = min;

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max ! arr[i] < min)
    {
            res =arr[i] - ar[i];
    }
} res++;
Console.WriteLine(res);
