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
//     if (n > m)
//     {
//         int t = n;
//         n = m;
//         m = t;
//     }
//     if (n <= m)
//     {
//         if (n == m)
//         {
//             return n;
//         }
//         else
//         {
//             return n + ShowNumSum(n + 1, m);
//         }
//     }
//     else
//     {
//         return 0;
//     }
// }

// Console.WriteLine("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// int summa = ShowNumSum(a, b);
// Console.Write($"Сумма чисел = {summa}");





// Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else if (m > 0 && n > 0)
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
//     else
//     {
//         return 0;
//     }
// }

// System.Console.WriteLine("Введите число m");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число n");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = Ackermann(m, n);
// Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
