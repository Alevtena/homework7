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



