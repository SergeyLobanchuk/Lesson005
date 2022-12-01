

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine($" Количество  чисел в массиве:\n");
int[] numbers = new int[10];


void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ ){
    Console.Write($"| {array[i] + " "} ");
  }
  Console.WriteLine();
}

int PositiveNum(int[] array)
{
    int number = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      number++;
    }
  }
  return number;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int number = PositiveNum(numbers);
Console.Write($"Количество чётных чисел в массиве: {number}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreatRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(1, 10);

    }
    return newArray;

}

void ShowArray(int[] numbers)
{
    Console.Write($"получившийся массив  -> [");
    for (int i = 0; i < numbers.Length; i++)
        Console.Write(numbers[i] + " ");
}


 int[] SumNegativeNum(int[] numbers)
 {

     int sum = 0;

 for (int a = 0; a < numbers.Length; a+=2)
    sum = sum + numbers[a];

    Console.WriteLine($"] -> сумма элементов cтоящих на нечётных позициях = {sum}");


  return numbers;
 }

Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatRandomArray(size);
ShowArray(myArray);
SumNegativeNum(myArray);

