//Задача 1.
//Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

//Через for

// void FindSumm(int num)
// {
//     int summ = 0;
//     for (int count = 1; count <= num; count++)
//     {
//         summ += count;
//         System.Console.Write(summ + " ");
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Сумма элементов от 1 до {num} равно {summ}");
// }
// System.Console.WriteLine("Введите число: ");
// int user_num = Convert.ToInt32(Console.ReadLine());
// if (user_num > 0)
// {
//     FindSumm(user_num);
// }
// else
//     System.Console.WriteLine("Невозможно");

//Через while

// void FindSumm(int num)
// {
//     int summ = 0;
//     int count = 1;
//     while (count <= num)
//     {
//         summ += count;
//         count++;
//         System.Console.Write(summ + " ");
//     }
//     System.Console.WriteLine($"Сумма элементов от 1 до {num} равно {summ}");
// }
//     System.Console.WriteLine("Введите число: ");
//     int user_num = Convert.ToInt32(Console.ReadLine());
//     if (user_num > 0)
//     {
//         FindSumm(user_num);
//     }
//     else
//         System.Console.WriteLine("Невозможно");





// Задача 2.
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//-78 -> 2
//89126 -> 5

// int NumCol(int number)
// {
//     int count = 0;
//     for (; number > 0;)
//     {
//         number /= 10;
//         count++;
//     }
//     return count;

// }
// void NumColPrint()
// {
//     System.Console.WriteLine("Введите число");
//     int result = Convert.ToInt32(Console.ReadLine());
//     int count_neg;
//     if (result >= 0)
//         count_neg = NumCol(result);
//     else
//     {
//         int user_num = (-1) * result;
//         count_neg = NumCol(user_num);
//     }
//     System.Console.WriteLine($"В вашем числе цифр: {count_neg}");
// }
// NumColPrint();





//Задача 3.
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

// int Proizv(int number)
// {
//     int multi = 1;
//     for(int count = 1; count <= number; count++)
//     {
//         multi *= count;
//     }
//     return multi;
// }
// System.Console.WriteLine("Введите число: ");
// int result = Convert.ToInt32(Console.ReadLine());
// int multi_res;
// if(result <= 0)
//     multi_res = 0;
// else
//     multi_res = Proizv(result);
// System.Console.WriteLine(multi_res);





//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1, 0, 1, 1, 0, 1, 0, 0]

// int[] CreateNewArray(int size_array)
// {
//     int[] random1array = new int[size_array];
//     for (int i = 0; i < size_array; i++)
//     {
//         random1array[i] = new Random().Next(0, 2);
//     }
//     return random1array;
// }
// void PrintArray(int[] array_to_print)
// {
//     System.Console.WriteLine("Держи массив:");
//     for (int i = 0; i < array_to_print.Length; i++)
//         Console.Write(array_to_print[i] + " ");
// }
// int size = 8;
// int[] firstArray = CreateNewArray(size);
// PrintArray(firstArray);