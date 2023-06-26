// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] RandomArray()
// {
//     int size = new Random().Next(2, 11);
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }

// void PrintArray(int[] arrayPrint)
// {
//     for (int i = 0; i < arrayPrint.Length; i++)
//     {
//         System.Console.Write(arrayPrint[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int Positive(int[] positive)
// {
//     int a = 0;
//     for (int i = 0; i < positive.Length; i++)
//         if (positive[i] % 2 == 0)
//             a++;
//     return a;
// }


// int[] a = RandomArray();
// PrintArray(a);
// int b = Positive(a);
// System.Console.WriteLine($"Колличество четныз цифр = {b}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] RandomArray()
// {
//     int size = new Random().Next(2,10);
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(-100, 100);
//     }
//     return arr;
// }

// void PrintArray(int[] arrayPrint)
// {
//     for (int i = 0; i < arrayPrint.Length; i++)
//     {
//         System.Console.Write(arrayPrint[i] + " ");
//     }
//     System.Console.WriteLine(" ");
// }

// int Summ(int[] summ)
// {
//     int sum = 0;
//     for (int i = 0; i < summ.Length; i++)
//     {
//         if (i % 2 != 0)
//             sum += summ[i];
//     }
//     return sum;
// }

// int[] a = RandomArray();
// PrintArray(a);
// int b = Summ(a);
// System.Console.WriteLine($"Сумма чисел с нечетным индексом = {b}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] RandomArray()
// {
//     int size = new Random().Next(1, 10);
//     double[] arr = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = (new Random().Next(1, 100)) + (new Random().NextDouble());
//     }
//     return arr;
// }

// void PrintArray(double[] arrayPrint)
// {
//     for (int i = 0; i < arrayPrint.Length; i++)
//     {
//         arrayPrint[i] = Math.Round(arrayPrint[i], 2);
//         System.Console.Write(arrayPrint[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// double MaxVal(double [] maxVal)
// {
//     double result = 0;
//     for (int i = 0; i < maxVal.Length; i++)
//     if (maxVal[i] > result)
//     {
//         result = maxVal[i];
//         result = Math.Round(result, 2);
//     }
//     return result;
// }

// double MinVal(double [] minVal)
// {
//     double result = minVal[0];
//     for (int i = 0; i < minVal.Length; i++)
//     if (minVal[i] < result)
//     {
//         result = minVal[i];
//         result = Math.Round(result, 2);
//     }
//     return result;
// }

// double[] a = RandomArray();
// PrintArray(a);
// double b = MaxVal(a);
// // System.Console.WriteLine($"{b}");
// double c = MinVal(a);
// // System.Console.WriteLine($"{c}");
// System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {b-c}");