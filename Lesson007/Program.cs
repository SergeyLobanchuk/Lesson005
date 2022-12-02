// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreatArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    }
    return newArray;

}

void ShowArray(int[] newArray)
{
    Console.Write($"Получившийся массив -> [ ");
    for (int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
}
Console.WriteLine();

void CountNum(int[] newArray)
{
    Console.Write($"]   количество чисел больше нуля -> ");
     int Count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0) 
        Count++;

    }
    Console.Write(Count);
}

Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите минимальное значение");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите максимальное значение");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreatArray(size, minValue, maxValue);
ShowArray(newArray);
CountNum(newArray);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double pointX;
double pointY;


Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int a = arr [1];
int b = arr [3];
int c = arr [0];
int d = arr [2];

if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double) (d-c)/(a-b);
    pointY = (double) a*(d-c)/(a-b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}