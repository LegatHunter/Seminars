// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// !!!ВОЗВРАТНЫЙ МЕТОД!!!

// int Number()
// {
//     System.Console.WriteLine("Введите трехзначное число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num >= 100 && num <= 999)
//     {
//         return (num = num / 10 % 10);
//     }
//     else if (num <= -100 && num >= -999)
//     {
//         return num = num / -10 % 10;
//     }
//     else
//     {
//         return -1;
//     }
// }
// int print = Number();
// if (print == -1) System.Console.WriteLine("Вы ввели не трехзначное число");
// else System.Console.WriteLine ($"Третье число = {print}");



// !!!НЕ ВОЗВРАТНАЯ ФУНКЦИЯ!!!

// void Number()
// {
//     System.Console.WriteLine("Введите трехзначное число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num >= 100 && num <= 999)
//     {
//         num = num / 10 % 10;
//         System.Console.WriteLine($"Третье число = {num}");
//     }
//     else if (num <= -100 && num >= -999)
//     {
//         num = num / -10 % 10;
//         System.Console.WriteLine($"Третье число = {num}");
//     }
//     else
//     {
//         System.Console.WriteLine($"Вы ввели не трехзначное число");
//     }
// }
// Number();



// !!!БЕЗ ФУНКЦИИ!!

// System.Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100 && num <= 999) 
// {
//     num = num / 10 % 10;
//     System.Console.WriteLine($"Третье число = {num}");
// }
// else if (num <= -100 && num >= -999)
// {
//     num = num / -10 % 10;
//     System.Console.WriteLine($"Третье число = {num}");
// }
// else
// {
//     System.Console.WriteLine($"Вы ввели не трехзначное число");  
// }





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//!!!ЧЕРЕЗ МЕТОД///

// int Three()
// {
//     int num = new Random().Next(1, 10000);
//     System.Console.WriteLine($"Ваше число {num}");
//     if (num >= 100)
//     {
//         while (num > 999)
//         {
//             num = num / 10;
//         }
//         num = num % 10;
//         return num;
//     }  
//      else
//      {
//         return (-1);
//      }
// }
// int temp = Three();
// if (temp == -1)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     System.Console.WriteLine($"Третья цифра = {temp}");
// }



//!!!НЕ ЧЕРЕЗ МЕТОД!!!

// int num = new Random().Next(1, 100000);
// System.Console.WriteLine($"Твое число {num}");
// if (num >= 100)
// {
//     while (num > 999)
//     {
//         num = num / 100;
//     }
//     num = num % 10;
//     System.Console.WriteLine($"Третья цифра данного числа = {num}");
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//!!!НАДО ПОПРОБОВАТЬ СДЕЛАТЬ ЧЕРЕЗ МЕТОД!!!

// System.Console.WriteLine("Введите  день недели");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 1 || day > 7)
// {
//     System.Console.WriteLine("Введите правильный день недели");
// }
// else
// {
//     if (day >= 1 && day <= 5)
//     {
//         System.Console.WriteLine("Будни");
//     }
//     else System.Console.WriteLine("Выходные");
// }


