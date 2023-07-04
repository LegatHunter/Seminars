// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] New2DArray()
// {
//     int line = new Random().Next(1, 10);
//     int colum = new Random().Next(1, 10);
//     int[,] new2DArray = new int[line, colum];
//     for (int i = 0; i < new2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < new2DArray.GetLength(1); j++)
//         {
//             new2DArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return new2DArray;
// }

// void Print2DArray(int[,] new2DArray)
// {
//     for (int i = 0; i < new2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < new2DArray.GetLength(1); j++)
//         {
//             System.Console.Write(new2DArray[i, j]);
//             System.Console.Write(" ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] Upor(int[,] new2DArray)
// {
//     int line = new2DArray.GetLength(0);
//     int colum = new2DArray.GetLength(1);
//     for (int row = 0; row < line; row++)
//     {
//         for (int i = 0; i < colum - 1; i++)
//         {
//             for (int j = 0; j < colum - 1 - i; j++)
//             {
//                 if (new2DArray[row, j] < new2DArray[row, j + 1])
//                 {
//                     int temp = new2DArray[row, j];
//                     new2DArray[row, j] = new2DArray[row, j + 1];
//                     new2DArray[row, j + 1] = temp;
//                 }
//             }
//         }
//     }
//     return new2DArray;
// }

// int[,] array2D = New2DArray();
// Print2DArray(array2D);
// int[,] upor = Upor(array2D);
// System.Console.WriteLine();
// Print2DArray(upor);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов строки.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] New2DArray()
// {
//     int line = 10;
//     int colum = 10;
//     int[,] new2DArray = new int[line, colum];
//     for (int i = 0; i < new2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < new2DArray.GetLength(1); j++)
//         {
//             new2DArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return new2DArray;
// }

// void Print2DArray(int[,] new2DArray)
// {
//     for (int i = 0; i < new2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < new2DArray.GetLength(1); j++)
//         {
//             System.Console.Write(new2DArray[i, j]);
//             System.Console.Write(" ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void Print1DArray(int[] new1DArray)
// {
//     for (int i = 0; i < new1DArray.Length; i++)
//     {
//         System.Console.Write(new1DArray[i]);
//         System.Console.Write(" ");
//     }
// }

// int [] Sum(int[,] new2DArray)
// {
//     int line = new2DArray.GetLength(0);
//     int colum = new2DArray.GetLength(1);
//     int [] sum = new int [line];
//     for (int i = 0; i < line; i++)
//     {
//         int summ = 0;
//         for (int j = 0; j < colum; j++)
//         {
//             summ += new2DArray[i,j];
//         }
//         sum[i] = summ;
//     }
//     return sum;
// }

// int MinVal(int [] array1D)
// {
//     int line = array1D.Length;
//     int minVal = array1D[0];
//     int minIndex = 0;
//     for (int i = 0; i < line; i++)
//     {
//         if (array1D[i] < minVal)
//         {
//         minVal = array1D[i];
//         minIndex = i;
//         }
//     }
//     System.Console.WriteLine();
//     return minIndex + 1;
// }

// int[,] array2D = New2DArray();
// System.Console.WriteLine("Двумерный массив: ");
// Print2DArray(array2D);
// int [] sum = Sum(array2D);
// System.Console.WriteLine();
// System.Console.Write("Сумма элементов каждой строки массива в виде одномерного массива: ");
// Print1DArray(sum);
// int minVal = MinVal(sum);
// System.Console.WriteLine();
// System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minVal} строка");





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] New2DArray()
// {
//     int line = 4; //new Random().Next(2, 5);
//     int colum = 4; //new Random().Next(2, 5);
//     int[,] new2DArray = new int[line, colum];
//     for (int i = 0; i < new2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < new2DArray.GetLength(1); j++)
//         {
//             new2DArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return new2DArray;
// }

// void Print2DArray(int[,] new2DArray)
// {
//     for (int i = 0; i < new2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < new2DArray.GetLength(1); j++)
//         {
//             System.Console.Write(new2DArray[i, j]);
//             System.Console.Write(" ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int [,] Proizv(int[,] firstArray, int [,] secondArray)
// {
//     int lineA = firstArray.GetLength(0);
//     int collumsA = firstArray.GetLength(1);
//     int collumsB = secondArray.GetLength(1);
//     int [,] proizv = new int [lineA, collumsB];
//     for (int i = 0; i < lineA; i++)
//     {
//         for (int j = 0; j < collumsB; j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < collumsA; k++)
//             {
//                 sum += firstArray[i,k] * secondArray[k,j];
//             }
//             proizv[i,j] = sum;
//         }
//     }
//     return proizv;
// }

// int[,] array2DFirst = New2DArray();
// System.Console.WriteLine("Первая матрица:");
// Print2DArray(array2DFirst);
// System.Console.WriteLine();
// int[,] array2DSecond = New2DArray();
// System.Console.WriteLine("Вторая матрица:");
// Print2DArray(array2DSecond);
// System.Console.WriteLine();
// int [,] proizv = Proizv(array2DFirst, array2DSecond);
// System.Console.WriteLine("произведение матриц:");
// Print2DArray(proizv);





// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07