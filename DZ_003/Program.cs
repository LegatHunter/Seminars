// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Метод по переворачиванию числа

// int PolindromMax(int number)
// {
//     int num1 = number % 10;
//     int num2 = number % 100 / 10;
//     int num3 = number % 1000 / 100;
//     int num4 = number % 10000 / 1000;
//     int num5 = number % 100000 / 10000;
//     int result = num1 * 10000 + num2 * 1000 + num3 * 100 + num4 * 10 + num5;
//     return result;
// }

// System.Console.WriteLine("Введите 5ти значное число: ");
// int numRL = Convert.ToInt32(Console.ReadLine());
// int poly = PolindromMax(numRL);
// if (numRL < 1000 || numRL >= 100000)
// {
//     System.Console.WriteLine("Вы ввели не 5ти значное число");
// }
// else if (numRL == poly)
// {
//     System.Console.WriteLine("Данное число является полиндромом");
// }
// else System.Console.WriteLine("Данное число НЕ является полиндромом");

//Метод по сравнению чисел только для плиндрома

// bool PolindromMin(int number)
// {
//     if (number % 10 == number % 100000 / 10000 && number % 100 / 10 == number % 10000 / 1000) return true;
//     else return false;
// }
// System.Console.WriteLine("Введите 5ти значное число: ");
// int numRL = Convert.ToInt32(Console.ReadLine());
// bool poly = PolindromMin(numRL);
// if (numRL < 1000 || numRL >= 100000)
// {
//     System.Console.WriteLine("Вы ввели не 5ти значное число");
// }
// else if (poly == true)
// {
//     System.Console.WriteLine("Данное число является полиндромом");
// }
// else System.Console.WriteLine("Данное число НЕ является полиндромом");





//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// A(x1, y1, z1); B(x2, y2, z2);
//     __________________________________________
//   \/(x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1)
// Math.Sqrt(25) - извлечение квадрата из 25

// double LongLineAB (int xA, int xB, int yA, int yB, int zA, int zB)
// {
//     double longLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA)*(zB - zA));
//     // longLine = Math.Round (longLine, 2); //Тоже самое что f:3 в выводе числа
//     return longLine;
// } 
// Console.Write("Введите x координату для А: ");
// int xCoordA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y координату для А: ");
// int yCoordA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z координату для А: ");
// int zCoordA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x координату для B: ");
// int xCoordB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y координату для B: ");
// int yCoordB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z координату для B: ");
// int zCoordB = Convert.ToInt32(Console.ReadLine());

// double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
// System.Console.WriteLine($"Дистанция {dist:f2}");



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int Kub(int num) {
//     int kub = num * num * num;
//     return kub;
// }
// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int one = 1;
// while (one <= number)
// {
//     int kub = Kub(one);
//     one++;
//     System.Console.Write($"{kub} ");
// }

// void Kub(int numberN) {
//     int count = 1;
//     while(count <= numberN){
//         double result = Math.Pow(count, 3);
//         System.Console.Write($"{result:f0}, ");
//         count++;
//     }
//     Console.WriteLine("\b\b.");
// }
// void KubNeg(int numberN) {
//     int count = 1;
//     while(count >= numberN){
//         double result = Math.Pow(count, 3);
//         System.Console.Write($"{result:f0}, ");
//         count--;
//     }
//     Console.WriteLine("\b\b.");
// }

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number > 0){
//     Kub(number);
// }
// else KubNeg(number);
