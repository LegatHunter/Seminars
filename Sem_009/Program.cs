// Задать значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShovNumbers(int n)
// {
//     if (n>1) ShovNumbers(n-1);
//     System.Console.Write(n + " ");
// }

// ShovNumbers(5);




// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowNumRange(int n, int m)
// {
//     // if (Math.Max(n,m) != Math.Min(n,m)) ShowNumRange(Math.Min(n,m) +1, Math.Max(n,m));
//     if(n!=m) ShowNumRange(Math.Min(n,m), Math.Max(n,m) - 1);
//     System.Console.Write($"{Math.Max(n,m)} ");
// }
// ShowNumRange(10,20);





// Напишите программу, которая будет принимать число и возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

// int SumDigits (int n)
// {
//     if (n<0) n*= (-1);
//     if (n == 0) return 0;
//     return SumDigits(n/10) + n % 10;
// }

// System.Console.WriteLine("Enter num");
// int n = Convert.ToInt32(Console.ReadLine());
// int summ = SumDigits(n);
// System.Console.Write($"Your sum is {summ}");





// Напишите программу, которая на входит принимает два числа А и В, и возвращает число А в целую степень В с помощью рекурсии.

// double FindPow(int a, int b)
// {
//     if (b == 0) return 1.0;
//     if (b > 0) return FindPow(a, b-1) * a;
//     return FindPow(a, b+1) / a;
// }

// double res = FindPow(2, -3);
// System.Console.WriteLine(res);





// Напишите программу, которая на входе принимает целое положительное десятичное число, а на выходе переводит его в бинарный формат.
// 4 -> 0100
// 5 -> 0101

// string DecToBin(int n, ref string s)
// {
//     if (n > 0)
//     {
//         DecToBin(n / 2, ref s);
//         s += (n%2).ToString();
//     }
//     if(n==0) return s;
//     return s;
// }

// System.Console.WriteLine("Enter num");
// int n = Convert.ToInt32(Console.ReadLine());
// string s = "";
// string summ = DecToBin(n, ref s);
// System.Console.Write($"0{summ}");