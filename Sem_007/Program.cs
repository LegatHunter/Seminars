//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

// int [,] Creat2DArray () //Создание 2 мерного массива
// {
//     System.Console.WriteLine("Введите количесво строк");
//     int userRows = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количесво столбцов");
//     int userColls = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите минимальное значение");
//     int userMin = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите максимальное значение");
//     int userMax = Convert.ToInt32(Console.ReadLine());

//     int [,] created2DArray = new int [userRows, userColls];
//     for(int i = 0; i < userRows; i++)
//     {
//         for(int j = 0; j<userColls; j++)
//         {
//             created2DArray[i,j] = new Random().Next(userMin, userMax + 1);
//         }
//     }
//     return created2DArray;
// }

// void Print2DArray (int [,] array2D)
// {
//     for(int i =0; i < array2D.GetLength(0); i++)
//     {
//         for(int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i,j] + " ");
//         }
//         System.Console.WriteLine(); //переход вывода на новую строку
//     }
//     System.Console.WriteLine(); //отступ от массива
// }

// int [,] new2dArray = Creat2DArray();
// Print2DArray(new2dArray);





/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3      [0,0] [0,1] [0,2] [0,3]  
1 2 3 4      [1,0] [1,1] [1,2] [1,3]
2 3 4 5
*/

// void Print2DArray (int [,] array2D)
// {
//     for(int i =0; i < array2D.GetLength(0); i++)
//     {
//         for(int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i,j] + " ");
//         }
//         System.Console.WriteLine(); //переход вывода на новую строку
//     }
//     System.Console.WriteLine(); //отступ от массива
// }

// int [,] FillArray ()
// {
// //     System.Console.WriteLine("Введите количесво строк");
//     int userRows = 3; //Convert.ToInt32(Console.ReadLine());
// //     System.Console.WriteLine("Введите количесво столбцов");
//     int userColls =4; //Convert.ToInt32(Console.ReadLine());
//     int [,] filled2Array = new int[userRows, userColls];

//     for(int i = 0; i < userRows; i++)
//     {
//         for(int j = 0; j < userColls; j++)
//         {
//             filled2Array[i,j] = i+j;
//         }
//     }
//     return filled2Array;
// }
// int [,] secondTaskArray = FillArray();
// Print2DArray(secondTaskArray);





//Задайте двумерный вещественный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

// double [,] Creat2DArray () //Создание 2 мерного массива
// {
//     System.Console.WriteLine("Введите количесво строк");
//     int userRows = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количесво столбцов");
//     int userColls = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите минимальное значение");
//     int userMin = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите максимальное значение");
//     int userMax = Convert.ToInt32(Console.ReadLine());

//     double [,] created2DArray = new double [userRows, userColls];
//     for(int i = 0; i < userRows; i++)
//     {
//         for(int j = 0; j<userColls; j++)
//         {
//             created2DArray[i,j] = Math.Round(new Random().Next(userMin, userMax + 1) + new Random().NextDouble(), 2);
//         }
//     }
//     return created2DArray;
// }

// double [,] ModiArray(double [,] arrayStart)
// {
//     for(int i = 0; i < arrayStart.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayStart.GetLength(1); j++)
//         {
//             if (i%2 == 0 && j%2 ==0)
//             {
//                 arrayStart[i,j] = Math.Round((arrayStart[i,j] * arrayStart[i,j]), 3);
//             }
//         }
//     }
//     return arrayStart;
// }

// void Print2DArray (double [,] array2D)
// {
//     for(int i =0; i < array2D.GetLength(0); i++)
//     {
//         for(int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i,j] + " ");
//         }
//         System.Console.WriteLine(); //переход вывода на новую строку
//     }
//     System.Console.WriteLine(); //отступ от массива
// }

// double [,] thirdTaskArray = Creat2DArray();
// Print2DArray(thirdTaskArray);
// double [,] modiArray = ModiArray(thirdTaskArray);
// Print2DArray(modiArray);





// Дан двумерный массив. Вывести на экран:
// а) все элементы пятой строки массива;
// б) все элементы s-го столбца массива.

// int [,] Creat2DArray () //Создание 2 мерного массива
// {
//     System.Console.WriteLine("Введите количесво строк");
//     int userRows = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количесво столбцов");
//     int userColls = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите минимальное значение");
//     int userMin = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите максимальное значение");
//     int userMax = Convert.ToInt32(Console.ReadLine());

//     int [,] created2DArray = new int [userRows, userColls];
//     for(int i = 0; i < userRows; i++)
//     {
//         for(int j = 0; j<userColls; j++)
//         {
//             created2DArray[i,j] = new Random().Next(userMin, userMax + 1);
//         }
//     }
//     return created2DArray;
// }

// void Print2DArray (int [,] array2D)
// {
//     for(int i =0; i < array2D.GetLength(0); i++)
//     {
//         for(int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i,j] + " ");
//         }
//         System.Console.WriteLine(); //переход вывода на новую строку
//     }
//     System.Console.WriteLine(); //отступ от массива
// }


// // int [,] taskArray = Creat2DArray();
// // Print2DArray(taskArray);

// // void Print5Line (int [,] array)
// // {
// //     System.Console.WriteLine("Введите какой столбец: ");
// //     for (int j = 0; j < array.GetLength(1); j++)
// //     {
// //         System.Console.Write(array[4,j] + " ");
// //     }
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         System.Console.Write(array[i,s] + " ");
// //     }
// // }
// // Print5Line(taskArray);




//Дан двумерный массив. Найти:
//а) сумму элементов, расположенных в левом верхнем и правом нижнем углах;
// [0,0] + [GetLength(0)-1; GetLength(1)-1]
//б) среднее арифметическое элементов, расположенных в четырех углах.

// int [,] Creat2DArray () //Создание 2 мерного массива
// {
//     System.Console.WriteLine("Введите количесво строк");
//     int userRows = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите количесво столбцов");
//     int userColls = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите минимальное значение");
//     int userMin = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите максимальное значение");
//     int userMax = Convert.ToInt32(Console.ReadLine());

//     int [,] created2DArray = new int [userRows, userColls];
//     for(int i = 0; i < userRows; i++)
//     {
//         for(int j = 0; j<userColls; j++)
//         {
//             created2DArray[i,j] = new Random().Next(userMin, userMax + 1);
//         }
//     }
//     return created2DArray;
// }

// void Print2DArray (int [,] array2D)
// {
//     for(int i =0; i < array2D.GetLength(0); i++)
//     {
//         for(int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i,j] + " ");
//         }
//         System.Console.WriteLine(); //переход вывода на новую строку
//     }
//     System.Console.WriteLine(); //отступ от массива
// }

// int [,] taskArray = Creat2DArray();
// Print2DArray(taskArray);

// double AvgArray (int [,] array)
// {
//     double sum = Math.Round(((array[0,0] + array[(array.GetLength(0)-1), (array.GetLength(1)-1)] + array[array.GetLength(0) - 1, 0] + array[0, array.GetLength(1)-1]) / 4.0), 2) ;
//     return sum;
// }

// System.Console.WriteLine(AvgArray(taskArray));
