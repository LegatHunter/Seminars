/*Console.ReadLine(); // работает со строкой
System.Console.WriteLine("Число дай: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Твой номер " + number);
System.Console.WriteLine($"Твой номер {number}");
Console.WriteLine("sdasd") */



// Задача на квадрат числа

// Console.WriteLine("Число дай: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int kvadro = number * number;
// Console.WriteLine($"Квадрат числа {number} = {kvadro}");



//Задача 3. 
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.WriteLine("Дай первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Дай второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int kvadro = number1 * number1;
// if (kvadro == number2)
// {
//     Console.WriteLine($"Число {number2} является квадратом числа {number1}");
// }
// else
// {
//     Console.WriteLine($"Число {number2} НЕявляется квадратом числа {number1}");
// }



//Задача 5.
//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.WriteLine("Дай число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = number * (-1);
// while (count <= number)
// {
//     Console.Write($"{count}");
//     count++;
// }



//Задача 7.
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// НАДО ДОДУМАТЬ ЗАДАЧУ
// Console.WriteLine("Дай число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000 || number < -99 && number > -1000) // && - логическое и: || - логическое или
// {
//     int number2 = number % 10;
//     Console.WriteLine($"Последнее число = {number2}");
// }
// else
// {
//     Console.WriteLine($"Число не трехзначное");
// }



// 456 % 10 = 6
// 456 / 10 = 45

// 456 % 100 = 56
// 456 / 100 = 4

// 456 % 1000 = 456
// 456 / 1000 = 0