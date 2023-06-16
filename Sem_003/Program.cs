//Пример возвратного метода

// int FunktName (int arg1, int arg2)
// {      // arg1 = number
//         //arg2 = 9
//         int del = arg1 % arg2;

// return del;   
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = FunktName(number, 9);
// Console.WriteLine($"{number} / 9 с остатком = {result}");
// int result1 = FunktName(1000, 78);
// Console.WriteLine($"1000 / 78 с остатком = {result1}");



//Пример НЕвозвратного метода

// void FunktName1 ()
// {      
//         Console.WriteLine("Введите число: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         int del = number % 9;
//         Console.WriteLine($"{number} / 9 с остатком = {del}");
// }
// FunktName1();



//Напишите программу, которая принимает на вход координаты точки (X и Y), причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой находится эта точка.

// Ось координат
// x > 0, y > 0 I quater
// x > 0, y < 0 IV quater
// x < 0, y < 0 III quater
// x < 0, y > 0 II quater

//Не возвратный метод

// void Quatro()
// {
//     System.Console.WriteLine("Введите число x: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите число y: ");
//     int y = Convert.ToInt32(Console.ReadLine());
//     if (x == 0 || y == 0)
//     {
//         System.Console.WriteLine("Не вводите 0");
//     }
//     else if (x > 0 && y > 0)
//     {
//         System.Console.WriteLine("I четверть");
//     }
//     if (x > 0 && y < 0)
//     {
//         System.Console.WriteLine("IV четверть");
//     }
//     if (x < 0 && y > 0)
//     {
//         System.Console.WriteLine("II четверть");
//     }
//     if (x < 0 && y < 0)
//     {
//         System.Console.WriteLine("III четверть");
//     }
// }
// Quatro();



//Возвратный метод

// int Koord(int x, int y)
// {
//     int numberQ = 0;

//     if (x > 0 && y > 0)
//     {
//         numberQ = 1;
//     }
//     if (x > 0 && y < 0)
//     {
//         numberQ = 4;
//     }
//     if (x < 0 && y > 0)
//     {
//         numberQ = 2;
//     }
//     if (x < 0 && y < 0)
//     {
//         numberQ = 3;
//     }
//     return numberQ;
// }
// System.Console.WriteLine("Введите число x: ");
// int xCoord = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число y: ");
// int yCoord = Convert.ToInt32(Console.ReadLine());
// int numbQuat = Koord(yCoord, xCoord);
// if (xCoord == 0 || yCoord == 0)
// {
//     System.Console.WriteLine("Не вводите 0");
//     while (xCoord == 0)
//     {
//         System.Console.WriteLine("Введи еще раз x");
//         xCoord = Convert.ToInt32(Console.ReadLine());
//     }
//     while (yCoord == 0)
//     {
//         System.Console.WriteLine("Введи еще раз y");
//         yCoord = Convert.ToInt32(Console.ReadLine());
//     }
// }
// else
// {
//     numbQuat = Koord (xCoord, yCoord);
//     System.Console.WriteLine($"Четверть {numbQuat}");
// }



//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

//Возвратный метод

// int Diapason (int quadro)
// {
//     if (quadro == 1)
//         return 1;
//     else if (quadro == 2)
//         return 2;
//     else if (quadro == 3)
//         return 3;
//     else
//         return 4;
// }
// System.Console.WriteLine("Введите четверть: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result;
// if (a <= 0 || a > 4) System.Console.WriteLine("Такой четверти нет!");
// else {
//     result = Diapason(a);

// if (result == 1)
// {
//     System.Console.WriteLine("Ваш диапазон x > 0 и y > 0");
// }
// else if (result == 2)
// {
//     System.Console.WriteLine("Ваш диапазон x < 0 и y > 0");
// }
// else if (result == 3)
// {
//     System.Console.WriteLine("Ваш диапазон x < 0 и y < 0");
// }
// else
// {
//     System.Console.WriteLine("Ваш диапазон x > 0 и y < 0");
// }
// }

//Не возвратный метод

// void PossibleValue(int quadro)
// {
//     if (quadro == 1)
//         Console.WriteLine("I четверть: x > 0, y > 0");
//     else if (quadro == 2)
//         Console.WriteLine("II четверть: x < 0, y > 0");
//     else if (quadro == 3)
//         Console.WriteLine("III четверть: x < 0, y < 0");
//     else
//         Console.WriteLine("IV четверть: x > 0, y < 0");
// }

// Console.WriteLine("Введите четверть: ");
// int numQater = Convert.ToInt32(Console.ReadLine());

// if (numQater >= 1 && numQater <= 4)
//     PossibleValue(numQater);
// else Console.WriteLine("Такой четверти нет");



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A(x1, y1); B(x2,y2)
//     __________________________________________
//   \/(x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1)
// Math.Sqrt(25) - извлечение квадрата из 25

// double LongLineAB (int xA, int xB, int yA, int yB)
// {
//     double longLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA));
//     // longLine = Math.Round (longLine, 2); //Тоже самое что f:3 в выводе числа
//     return longLine;
// } 
// Console.Write("Введите x координату для А: ");
// int xCoordA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y координату для А: ");
// int yCoordA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x координату для B: ");
// int xCoordB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y координату для B: ");
// int yCoordB = Convert.ToInt32(Console.ReadLine());

// double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB);
// System.Console.WriteLine($"Дистанция {dist:f3}");



//Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4.

// void SquarePrinter(int numberN)
// {
//     int current = 1;
//     while (current <= numberN)
//     {
//         double res = Math.Pow(current, 2);
//         System.Console.Write($"{res:f0}, ");
//         current++;
//     }
//     System.Console.WriteLine("\b\b.");
// }
// void SquarePrinterNeg(int numberN)
// {
//     int current = 1;
//     while (current >= numberN)
//     {
//         double res = Math.Pow(current, 2);
//         System.Console.Write($"{res:f0}, ");
//         current--;
//     }
//     System.Console.WriteLine("\b\b.");
// }
// System.Console.Write("Input numner: ");
// int user_number = Convert.ToInt32(Console.ReadLine());
// if(user_number > 0)
//     SquarePrinter(user_number);
// else 
//     SquarePrinterNeg(user_number);