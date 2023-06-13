
// !!!РАСКОМЕНТИТЬ МНОГО СТРОК СРАЗУ - CTRL + /!!!

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// System.Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(System.Console.ReadLine());
// int max = 0;
// int min = 0;
// if(number1 > number2)
// {
//     max = number1;
//     min = number2;
// }
// else
// {
//     max = number2;
//     min = number1;
// }
// System.Console.WriteLine($"Максимальное число = {max}, а минимальное = {min}.");





// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// System.Console.WriteLine("Введите первое число");
// int max = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());
// if(b > max && b > c)
// {
//     max = b;
// }
// if(c > max && c > b)
// {
//     max = c;
// }
// System.Console.WriteLine($"Максимальное число = {max}");





// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Введтите ваше число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 1 || a % 2 == -1) {
//     Console.WriteLine("Ваше число не четное");
// }
// else {
//     Console.WriteLine("Ваше число четное");
// }





// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.WriteLine ("Введите ваше число");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 2;
//  while (a >= b){
//     Console.Write($"{b}, ");
//     b = b + 2;
// }