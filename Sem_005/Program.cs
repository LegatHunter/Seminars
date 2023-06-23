//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

// int [] CreateArray (int size, int minVal, int maxVal)
// {
//     int [] newArray = new int [size];
//     for (int i =0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return newArray;
// }

// void ShowArray(int [] arrayToShow)
// {
//     for (int i = 0; i<arrayToShow.Length; i++)
//         System.Console.Write(arrayToShow[i] + " ");
//     System.Console.WriteLine();
// }

// void FindSumNegElem (int [] array)
// {
//     int sumNegElem = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] < 0)
//             sumNegElem += array[i];
//     System.Console.WriteLine($"Сумма отрицательных значений массива = {sumNegElem}");
// }

// int FindSumPosElem (int [] arrayToAnalyse)
// {
//     int sumPosElem = 0;
//     for (int i = 0; i < arrayToAnalyse.Length; i++)
//         if (arrayToAnalyse[i] > 0)
//             sumPosElem += arrayToAnalyse[i];
//     return sumPosElem;
// }


// // void FindSumElem (int [] array)
// // {
// //     int sumNegElem = 0;
// //     int sumPosElem = 0;
// //     for (int i = 0; i < array.Length; i++)
// //         if (array[i] < 0)
// //             sumNegElem += array[i];
// //         if (array[i] > 0)
// //             sumPosElem += array[i];
// //     System.Console.WriteLine($"Сумма отрицательных значений массива = {sumNegElem}");
// //     System.Console.WriteLine($"Сумма положительных значений массива = {sumPosElem}");
// // }

// int sizeArray = 12;
// int minArrayVal = -9;
// int maxArrayVal = 9;

// int [] createdArray = CreateArray(sizeArray, minArrayVal, maxArrayVal);
// ShowArray(createdArray);
// FindSumNegElem (createdArray);
// int positiveSumm = FindSumPosElem(createdArray);
// System.Console.WriteLine($"Сумма положительных значений массива = {positiveSumm}");




//Задача 2.
//Напишите программу замены элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] RandomArray ()
// {
//     int size = new Random().Next(4, 10);
//     int [] randomArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i] = new Random().Next(-10, 11);
//     }
//     return randomArray;
// }

// void PrintArray(int [] arrayPrint)
// {
//     for (int i = 0; i < arrayPrint.Length; i++)
//     {
//         System.Console.Write(arrayPrint[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int [] InvertArray(int [] invertArray)
// {
//     for  (int i = 0; i < invertArray.Length; i++)
//         invertArray[i] = invertArray[i] * (-1);
//     return invertArray;
// }

// int [] massiv = RandomArray();
// PrintArray(massiv);
// int[] invertArray = InvertArray(massiv);
// PrintArray(massiv);

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

// int[] RandomArray()
// {
//     int size = new Random().Next(4, 10);
//     int[] randomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i] = new Random().Next(-10, 11);
//     }
//     return randomArray;
// }
// void PrintArray(int[] arrayPrint)
// {
//     for (int i = 0; i < arrayPrint.Length; i++)
//     {
//         System.Console.Write(arrayPrint[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] startArray = RandomArray();
// int size = startArray.Length;
// int[] MultyArray(int[] startArray)
// {
//     int[] temp;
//     if (size % 2 == 0)
//         temp = new int[size / 2];
//     else
//     {
//         temp = new int[size / 2 + 1];
//         temp[size / 2] = startArray[size / 2];
//     }
//     for (int i = 0; i < size / 2; i++)
//     {

//         temp[i] = startArray[i] * startArray[startArray.Length - 1 - i];

//     }
//     return temp;
// }

// PrintArray(startArray);
// int[] multy = MultyArray(startArray);
// PrintArray(multy);




//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

// int[] RandomArray()
// {
//     int size = 123;
//     int[] randomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i] = new Random().Next(0, 101);
//     }
//     return randomArray;
// }

// void PrintArray(int[] arrayPrint)
// {
//     for (int i = 0; i < arrayPrint.Length; i++)
//     {
//         System.Console.Write(arrayPrint[i] + " ");
//     }
//     System.Console.Write("");
// }

// void CountOfElem(int [] countArray)
// {
//     int count = 0;
//     for(int i = 0; i < countArray.Length; i++)
//     {
//         if (countArray[i] >= 10 && countArray[i] <= 99)
//         count++;
//     }
//     System.Console.Write($"-> {count}");
// }

// int [] randomArray = RandomArray();
// PrintArray(randomArray);
// CountOfElem(randomArray);




// double - число с точкой
// Random().NextDouble() *10