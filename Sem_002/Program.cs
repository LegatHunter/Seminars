// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int Line(){
//     int num = new Random().Next(10,100);
//     Console.WriteLine($"Твое число {num}");
//     int dec = num / 10;
//     int ed = num % 10;
//     if(dec>ed){
//         return dec;
//     }
//     else{
//         return ed;
//     }
// }

// System.Console.WriteLine($"Результат  {Line()}"); 





//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100, 1000);
// System.Console.WriteLine($"Твое число {num}");
// int a = num % 10;
// int b = num / 100;
// System.Console.WriteLine($"Результат  {b}{a}");





// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// System.Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 != 0 && num1 != 0){
//     if (num2 % num1 == 0){
//         System.Console.WriteLine($"Число {num2} кратное {num1}");
//     }
//     else{
//         System.Console.WriteLine("Остаток = " + num2 % num1);
//     }
// }
// else{
//     System.Console.WriteLine("Не вводи 0)))");
// }





// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// int Line(){
//     System.Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num % 7 == 0 && num % 23 == 0){
//         return 0;
//     }
//     else{
//         return 1;
//     }
// }
// int line = Line();
// if (line == 1){
//     System.Console.WriteLine("Не кратно");
// }
// else {
//     System.Console.WriteLine("Кратно");
// }





// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// System.Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите первое число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 == 0 || num1 == 0)
// {
//     System.Console.WriteLine("Айяйяй, чур 0 не писать");
// }
// else if (num1 == num2 * num2 || num2 == num1 * num1)
// {
//     System.Console.WriteLine("Число является квадратом");
// }
// else
// {
//     System.Console.WriteLine("Число не является квадратом");
// }