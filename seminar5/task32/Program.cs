//Задача 32: Напишите программу замена элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

const int SIZE = 12;  // длина массива , левая и правая границы
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] array = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(",",arr));

for (int i = 0; i < SIZE; i++)
{
    arr[i] = array[i] * -1;
}

Console.WriteLine(string.Join(",",arr));
