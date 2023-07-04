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
//     if(line <= 0 || colum <= 0) System.Console.WriteLine("Такого массива не существует");
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

// int[,] New2DArray()
// {
//     int line = new Random().Next(1,10);
//     int colum = new Random().Next(1,10);
//     int[,] new2DArray = new int[line, colum];
//     for (int i = 0; i < new2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < new2DArray.GetLength(1); j++)
//         {
//             new2DArray[i, j] = new Random().Next(-10, 10);
//         }
//     }
//     return new2DArray;
// }

// void PositionArray(int[,] userArray)
// {
//     System.Console.WriteLine("Введите номер строки: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     row--;
//     System.Console.WriteLine("Введите номер столбца: ");
//     int colum = Convert.ToInt32(Console.ReadLine());
//     colum--;
//     if (row >= userArray.GetLength(0) || colum >= userArray.GetLength(1) || row <= 0 || colum <= 0) System.Console.WriteLine("Такого числа нет");
//     if (row >= 0 && row < userArray.GetLength(0) && colum >= 0 && colum < userArray.GetLength(1))
//     {
//         int position = userArray[row, colum];
//         System.Console.WriteLine($"Ваше число = {position}");
//     }
// }

// void Print2DArray(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j]);
//             System.Console.Write(" ");
//         }
//         System.Console.WriteLine(" ");
//     }
// }
// int[,] new2DArrayP = New2DArray();
// Print2DArray(new2DArrayP);
// PositionArray(new2DArrayP);





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] NewArray()
// {
//     int line = new Random().Next(1,10);
//     int colum = new Random().Next(1,10);
//     int [,] newArray = new int [line, colum];
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             newArray[i,j] = new Random().Next(0,10); 
//         }
//     }
//     return newArray;
// }

// void PrintNewArray(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j]);
//             System.Console.Write(" ");
//         }
//         System.Console.WriteLine(" ");
//     }
// }

// double [] Arifm(int [,] array2D)
// {
//     int line = array2D.GetLength(0);
//     int colum = array2D.GetLength(1);
//     double [] result = new double [colum];
//     for (int i = 0; i < colum; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < line; j++)
//         {
//             sum += array2D[j,i];
//         }
//         result[i] = Math.Round((double) sum/line, 1);
//     }
//     return result;
// }

// void PrintArifmArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]);
//         System.Console.Write(" ");
//     }
//     System.Console.WriteLine(" ");
// }

// int[,] new2DArrayP = NewArray();
// PrintNewArray(new2DArrayP);
// double [] arifm = Arifm(new2DArrayP);
// System.Console.Write("Среднее арифметическое каждого столбца = ");
// PrintArifmArray(arifm);