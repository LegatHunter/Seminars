// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] Array2D()
// {
//     System.Console.WriteLine("Введите количество строк: ");
//     int line = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количество столбцов: ");
//     int colum = Convert.ToInt32(Console.ReadLine());
//     double [,] array2D = new double [colum,line];

//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i,j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()), 1);
//         }
//     }
//     return array2D;
// }

// void Print2DArray(double [,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i,j]);
//             System.Console.Write(" ");
//         }
//         System.Console.WriteLine(" ");
//     }
// }

// double [,] new2DArray = Array2D();
// Print2DArray(new2DArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] New2DArray()
{
    int line = 4;
    int colum = 4;
    int[,] new2DArray = new int[line, colum];
    for (int i = 0; i < new2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < new2DArray.GetLength(1); j++)
        {
            new2DArray[i, j] = new Random().Next(-10, 10);
        }
    }
    return new2DArray;
}

void PositionArray(int[,] userArray)
{
    System.Console.WriteLine("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    row -= 1;
    System.Console.WriteLine("Введите номер столбца: ");
    int colum = Convert.ToInt32(Console.ReadLine());
    colum -= 1;
    if (row >= 0 && row < userArray.GetLength(0) && colum >= 0 && colum < userArray.GetLength(1))
    {
        int position = userArray[row, colum];
        System.Console.WriteLine(position);
    }
}

void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j]);
            System.Console.Write(" ");
        }
        System.Console.WriteLine(" ");
    }
}
int[,] new2DArrayP = New2DArray();
Print2DArray(new2DArrayP);
PositionArray(new2DArrayP);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.