//Вычислить сумму чисел нацело делящихся на 5. Цикл задать от 0 до введенного с клавиатуры числа

// int Summa(int number)
// {
//     int sum = 0;
//     for(int i = 0; i <= number; i++)
//     {
//         if (i % 5 == 0) 
//             {
//             sum += i;
//             }
//     }
//     return sum;
//  }
// System.Console.WriteLine("Введи номер: ");
// System.Console.WriteLine(Summa(Convert.ToInt32(Console.ReadLine())));


/* Дано натуральное число. Определить:
а) количество цифр в нем;
б) сумму его цифр;
в) произведение его цифр;
г) среднее арифметическое его цифр;
д) сумму квадратов его цифр;
е) сумму кубов его цифр;
ж) его первую цифру;
з) сумму его первой и последней цифр.
*/

// void Col(int num)
// {
//     int length = 0;
//     while (num >= 1)
//     {
//         num /= 10;
//         length++;
//     }
//     System.Console.WriteLine($"Колличество цифр: {length}");
// }
// Col(123456789);

// void Summ(int num)
// {
//     int summ = 0;
//     while (num >=1)
//     {
//         summ += num % 10;
//         num /= 10;
//     }
//     System.Console.WriteLine($"Сумма цифр заданного числа: {summ}");
// }
// Summ(17);

// void Pro(int num)
// {
//     int pro = 1;
//     while (num >=1)
//     {
//         pro *= num % 10;
//         num /= 10;
//     }
//     System.Console.WriteLine($"Произведение цифр заданного числа: {pro}");
// }
// Pro(27);

// void Avg(int num)
// {
//     int summ = 0;
//     double length = 0;
//     while (num >=1)
//     {
//         summ += num % 10;
//         num /= 10;
//         length++;
//     }
//     double avg = summ / length;
//     System.Console.WriteLine($"Среднее арифметическое: {avg}"); 
// }
// Avg(12);

// void SumQ(int num)
// {
//     int summ = 0;
//     while (num >=1)
//     {
//         summ += (num % 10) * (num % 10);
//         num /= 10;
//     }
//     System.Console.WriteLine($"Сумма квадратов числа: {summ}"); 
// }
// SumQ(15);

// void SumQ2(int num)
// {
//     int summ = 0;
//     while (num >=1)
//     {
//         summ += (num % 10) * (num % 10) * (num % 10);
//         num /= 10;
//     }
//     System.Console.WriteLine($"Сумма кубов числа: {summ}"); 
// }
// SumQ2(125);


// Определить минимальное число, большее 200, которое нацело делится на 17. 


//Найти максимальное из натуральных чисел, не превышающих 5000, которое нацело делится на 39


