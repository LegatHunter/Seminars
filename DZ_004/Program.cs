// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Quadro(int numA, int numB)
// {
//     int result = 1;
//     for(int i = 1; i <= numB; i++)
//     result *= numA;
//     return result;
// }
// void Res()
// {
// System.Console.WriteLine("Введите число A: ");
// int userA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число B");
// int userB = Convert.ToInt32(Console.ReadLine());
// if(userA > 0)
// {
// int result = Quadro(userA, userB);
// System.Console.WriteLine($"Результат = {result}");
// }
// else
// {
//     System.Console.WriteLine("Не вводи 0");
// }
// }
// Res();





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Summ(int user_num)
// {
//     int result = 0;
//     for( ;user_num != 0; user_num /= 10)
//     {
//         result += user_num % 10;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число: ");
// int user_num1 = Summ(Convert.ToInt32(Console.ReadLine()));
// System.Console.WriteLine($"Сумма цифр = {user_num1}");





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] Array(int size)
// {
//     int[] user_arr = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write("Введите число: ");
//         user_arr [i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return user_arr;
// }
// void PrintArray(int[] arrayP)
// {
//     System.Console.WriteLine("Массив: ");
//     for (int i = 0; i < arrayP.Length; i++)
//         System.Console.Write(arrayP[i] + " ");
// }
// int size = 8;
// int [] arrayF = Array(size);
// PrintArray(arrayF);
