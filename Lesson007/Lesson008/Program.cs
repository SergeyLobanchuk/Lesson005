// Задача 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

ShowArray();
PrintAverageInColumns();

void PrintAverageInColumns()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }

        average = average / array.GetLength(0);
        Console.Write($"{average: 0.00}\t");
    }
}

void ShowArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}

// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void CreatAndShowArray(int rows, int columns)  
{      
    
    double [,] newArray = new double[rows, columns];

    Random value = new Random(); 
    
    if( rows > 0 && columns > 0)
    {
        
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
            newArray[i,j] =Math.Round(value.Next(-100, 100) + value.NextDouble(), 2);
            }
        }

       
        for(int i = 0; i < rows ;i++ ) 
            {
                for(int j = 0; j < columns; j++)  
                {
                Console.Write(newArray[i,j] + " ");
                }
                Console.WriteLine(); 
            }
    }
    else Console.WriteLine("Ошибка ввода данных");
}

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
CreatAndShowArray(rows,columns);