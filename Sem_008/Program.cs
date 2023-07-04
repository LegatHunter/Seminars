//Задача 1.
//Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива.

// int[,] Created2dArray(int rows, int collums, int minV, int maxV)
// {
//     int[,] createdArray = new int[rows, collums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < collums; j++)
//         {
//             createdArray[i, j] = new Random().Next(minV, maxV + 1);
//         }
//     }
//     return createdArray;
// }

// void ShowArray(int[,] printedArray)
// {
//     for (int i = 0; i < printedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printedArray.GetLength(1); j++)
//         {
//             System.Console.Write(printedArray[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] ChangeRows(int[,] arrayToChnge, int row1, int row2)
// {
//     if (row1 >= 0 && row1 < arrayToChnge.GetLength(0) && row1 != row2 && row2 >= 0 && row2 < arrayToChnge.GetLength(0))
//     {
//         for (int j = 0; j < arrayToChnge.GetLength(1); j++)
//         {
//             int temp = arrayToChnge[row1, j];
//             arrayToChnge[row1, j] = arrayToChnge[row2, j];
//             arrayToChnge[row2, j] = temp;
//         }
//     }
//     else System.Console.WriteLine("Не правильные значения");
//     return arrayToChnge;
// }

// System.Console.Write("Введите количесвто строк: ");
// int user_rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов: ");
// int user_collums = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите минимальное число: ");
// int user_min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите максимальное число: ");
// int user_max = Convert.ToInt32(Console.ReadLine());


// int[,] created2dArray = Created2dArray(user_rows, user_collums, user_min, user_max);
// ShowArray(created2dArray);

// System.Console.Write($"Введите номер строки от 0 до {user_rows - 1}: ");
// int user_first_row = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($"Введите номер строки от 0 до {user_rows - 1}: ");
// int user_second_row = Convert.ToInt32(Console.ReadLine());

// ShowArray(ChangeRows(created2dArray, user_first_row, user_second_row));





//Задача 2.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] Created2dArray(int rows, int collums)
// {
//     int[,] createdArray = new int[rows, collums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < collums; j++)
//         {
//             createdArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return createdArray;
// }

// void ShowArray(int[,] printedArray)
// {
//     for (int i = 0; i < printedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printedArray.GetLength(1); j++)
//         {
//             System.Console.Write(printedArray[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] ChangeRows(int[,] arrayToChnge)
// {
//     if (arrayToChnge.GetLength(0) == arrayToChnge.GetLength(1))
//     {
//         for (int i = 0; i < arrayToChnge.GetLength(0); i++)
//         {
//             for (int j = i; j < arrayToChnge.GetLength(1); j++)
//             {
//             int temp = arrayToChnge[i, j];
//             arrayToChnge[i, j] = arrayToChnge[j, i];
//             arrayToChnge[j, i] = temp;
//             }
//         }
//     }
//     else System.Console.WriteLine("Невозможно");
//     return arrayToChnge;
// }

// System.Console.Write("Введите количесвто строк: ");
// int user_rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов: ");
// int user_collums = Convert.ToInt32(Console.ReadLine());

// int[,] created2dArray = Created2dArray(user_rows, user_collums);
// ShowArray(created2dArray);
// ShowArray(ChangeRows(created2dArray));





//Задача 3.
// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец, 
// на пересечении которых расположен первый наименьший элемент массива.

// int[,] Created2dArray(int rows, int collums)
// {
//     int[,] createdArray = new int[rows, collums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < collums; j++)
//         {
//             createdArray[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return createdArray;
// }

// void ShowArray(int[,] printedArray)
// {
//     for (int i = 0; i < printedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printedArray.GetLength(1); j++)
//         {
//             System.Console.Write(printedArray[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int [] FindFirstMin (int [,] arrayToAnalyse)
// {
//     int min = arrayToAnalyse[0,0];
//     int [] coord = new int [2];
//     for (int i = 0; i < arrayToAnalyse.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayToAnalyse.GetLength(1); j++)
//         {
//             if (min > arrayToAnalyse[i,j])
//             {
//                 min = arrayToAnalyse[i,j];
//                 coord [0]= i;
//                 coord [1] = j;
//             }
//         }
//     }
//     return coord;
// }

// int [,] arrayToDem (int [,] arrayToProcess, int [] coordArra)
// {
//     for (int i = 0; i < arrayToProcess.GetLength(0); i++)
//     {
//         arrayToProcess[i, coordArra[1]] = 0;
//     }
//      for (int j = 0; j < arrayToProcess.GetLength(1); j++)
//     {
//         arrayToProcess[coordArra[0], j] = 0;
//     }
//     return arrayToProcess;
// }
// Console.Write("Введите количество строк: ");
// int userRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количесвто столбцов: ");
// int userColumns = Convert.ToInt32(Console.ReadLine());

// int [,] arrayFromUser = Created2dArray(userRows, userColumns);
// ShowArray(arrayFromUser);
// int [] coordUser = FindFirstMin(arrayFromUser);
// int [,] finalArray = arrayToDem(arrayFromUser, coordUser);
// ShowArray(finalArray);