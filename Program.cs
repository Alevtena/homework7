// Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
// числами.

/*m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/* double[,] CreateRandom2dArray(int rows, int colums) 
{
    double[,] array = new double [rows,colums];
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()+new Random().Next(-9,9);
            array[i,j]=Math.Round(array[i,j],2);
        }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Input a rows of array");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a colums of array");
int colums = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows,colums);
Show2dArray(myArray); */


// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет */

/* int[,] CreateRandom2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<colums; j++)
            array[i,j] = new Random().Next(1,10);
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void  NumberOfArray(int[,] array, int n, int m)
{
    if (n < array.GetLength(0) && m < array.GetLength(1)) 
    {
        int c = array[n,m]; 
        Console.Write($"array[{n},{m} = {c}");
    }
    else Console.Write("Такого элемента не существует");
}

Console.Write("Input a rows of array" + " ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a colums of array" + " ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of rows" + " ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums" + " ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows,colums);
Show2dArray (myArray);
NumberOfArray(myArray, n, m); */

// Task 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */

int[,] CreateRandom2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<colums; j++)
            array[i,j] = new Random().Next(1,10);
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

double AverageColums(int[,] array)
{
    for (int j=0; j < array.GetLength(0); j++)
    {
        int average = 0; 
        for (int i=0; i < array.GetLength(1); i++)
        {
            average += array[i,j];
        }
        double srAr = average/array.GetLength(1);
        return average;
    }
}
Console.Write("Input a rows of array" + " ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a colums of array" + " ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows,colums);
Show2dArray (myArray);
AverageColums(myArray);

