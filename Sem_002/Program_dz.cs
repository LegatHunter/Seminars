// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// int Promt(string message)
// {
//     System.Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Promt("Введите трехзначное число > ");
// if (number < 100 || number >= 1000)
// {
//     System.Console.WriteLine("Не трехзначное число");
//     return;
// }
// System.Console.WriteLine($"Введеное число {number}");
// int secondRank = number / 10 % 10;
// System.Console.WriteLine($"Вторая цифра {secondRank}");