// Задача 41: Пользователь вводит с клавиатуры n чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateNewArray()
{
    System.Console.WriteLine("Введите длинну массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] userArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine("Введите элемент массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        userArray[i] = n;
    }
    return userArray;
}

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        System.Console.Write($"{arrayToShow[i]}");
        if (i != arrayToShow.Length - 1) System.Console.Write(", ");
        else System.Console.Write(".");
    }
    System.Console.WriteLine();
}

int CountArray(int [] userArray)
{
    int count = 0;
    for(int i = 0; i < userArray.Length; i++)
    if (userArray[i] > 0) count++;
    return count;
}

int[] createdArray = CreateNewArray();
ShowArray(createdArray);
int c = CountArray(createdArray);
System.Console.WriteLine($"Количество чисел > 0 = {c}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y = k1*x + b1
// y = k2*x + b2

//k1*x + b1 = k2*x + b2
//k1*x - k2*x = b2 - b1
//x(k1 - k2) = b2-b1
//x = (b2 - b1) / (k1 - k2)

// void ShowArray(double[] arrayToShow)
// {
//     for (int i = 0; i < arrayToShow.Length; i++)
//     {
//         System.Console.Write($"{arrayToShow[i]}");
//         if (i != arrayToShow.Length - 1) System.Console.Write(", ");
//         else System.Console.Write(".");
//     }
//     System.Console.WriteLine();
// }

// double [] NewArray()
// {
//     System.Console.Write("Введите b1: ");
//     double b1 = Convert.ToInt32(Console.ReadLine());
//     System.Console.Write("Введите b2: ");
//     double b2 = Convert.ToInt32(Console.ReadLine());
//     System.Console.Write("Введите k1: ");
//     double k1 = Convert.ToInt32(Console.ReadLine());
//     System.Console.Write("Введите k2: ");
//     double k2 = Convert.ToInt32(Console.ReadLine());
//     double x = (b2 - b1) / (k1 - k2);
//     double y1 = Math.Round(k1 * x + b1, 2);
//     double y2 = Math.Round(k2 * x + b2, 2);
//     int size = 2;
//     double [] newArray = new double[size];
//     int i = 0;
//     newArray[i] = y1;
//     newArray[i++] = y2;
//     return newArray;
// }
// double [] arr = NewArray();
// System.Console.Write("Точка пересечения двух прямых = ");
// ShowArray(arr);
