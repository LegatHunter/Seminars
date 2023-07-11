// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NumDigit(int n)
// {
//     if (n < 0) NumDigit(n + 1);
//     System.Console.Write($"{n} ");
//     if (n > 1)
//     {
//         NumDigit(n - 1);
//     }
// }

// System.Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Последовательность чисел:");
// NumDigit(num);





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int ShowNumSum(int n, int m)
// {
//     if (n <= m) return n + ShowNumSum(n + 1, m);
//     else return 0;
// }

// System.Console.WriteLine("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// int summa = ShowNumSum(a, b);
// System.Console.Write($"Cумма чисел = {summa}");

Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29