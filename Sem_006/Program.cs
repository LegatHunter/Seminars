//Напишшите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на посследнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int [] CreateNewArray(int size, int minV, int maxV)
// {
//     int [] arrayNew = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         arrayNew[i] = new Random().Next(minV, maxV + 1);
//     }
//     return arrayNew;
// }

// void ShowArray (int [] arrayToShow)
// {
//     for(int i = 0; i < arrayToShow.Length; i++)
//     {
//         System.Console.Write($"{arrayToShow[i]}");
//         if (i != arrayToShow.Length - 1) System.Console.Write(", ");
//         else System.Console.Write(".");
//     }
// System.Console.WriteLine();
// }

// int [] ReversArray(int [] arrayRevers)
// {
//     int k = arrayRevers.Length;
//     for(int i = 0; i < k/2; i++)
//     {
//         int temp = arrayRevers[i];
//         arrayRevers[i] = arrayRevers[k - 1 - i];
//         arrayRevers[k - 1 - i] = temp;
//     }
//     return arrayRevers;
// }

// int size_array = 7;
// int min_val_arr = -9;
// int max_val_arr = 9;

// int [] createdArray = CreateNewArray(size_array, min_val_arr, max_val_arr);
// ShowArray(createdArray);
// int [] reversedArray = ReversArray(createdArray);
// ShowArray(reversedArray);





//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11

// int CountOfBinar (int user_num)
// {
//     int countOfDigit = 0;
//     while (user_num != 0)
//     {
//         user_num /= 2;
//         countOfDigit++;
//     }
//     return countOfDigit;
// }

// void ShowArray (int [] arrayToShow)
// {
//     for(int i = 0; i < arrayToShow.Length; i++)
//     {
//         System.Console.Write($"{arrayToShow[i]}");
//         if (i != arrayToShow.Length - 1) System.Console.Write(", ");
//         else System.Console.Write(".");
//     }
// System.Console.WriteLine();
// }

// int [] ConversionToBinar(int numToConvert)
// {
//     int n = CountOfBinar(numToConvert);
//     int [] binarNum = new int [n];

//     for(int i = n-1; i >= 0; i--)
//     {
//         binarNum[i] = numToConvert % 2;
//         numToConvert /= 2;
//     }
//     return binarNum;
// }

// int userNumber = 75;
// int countElem = CountOfBinar(userNumber);
// int [] binar = ConversionToBinar(userNumber);
// ShowArray(binar);





//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b (пользователь).
// a b a+b (b + a+b) (a+b)(b + a+b)
// 1 2  3     4             5

// void ShowArray(int[] arrayToShow)
// {
//     for (int i = 0; i < arrayToShow.Length; i++)
//     {
//         System.Console.Write($"{arrayToShow[i]}");
//         if (i != arrayToShow.Length - 1) System.Console.Write(", ");
//         else System.Console.Write(".");
//     }
//     System.Console.WriteLine();
// }

// void Fibonachy(int n, int a, int b)
// {
//     int[] arrFib = new int[n];
//     arrFib[0] = a;
//     arrFib[1] = b;
//     for (int i = 2; i < n; i++)
//     {
//         arrFib[i] = arrFib[i - 1] + arrFib[i - 2];
//     }
//     ShowArray(arrFib);
// }

// System.Console.WriteLine($"Введите количество элементов: ");
// int userCount = Convert.ToInt32(Console.ReadLine());


// if (userCount > 2)
// {
//     System.Console.WriteLine($"Введите первое число: ");
//     int userFirstNum = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine($"Введите второе число: ");
//     int userSecondNum = Convert.ToInt32(Console.ReadLine());
//     Fibonachy(userCount, userFirstNum, userSecondNum);
// }
// else System.Console.WriteLine("Низя!");





//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. Каждая сторона треугольника меньше суммы двух других сторон.
//a < b + c
//b < a + c
//c < a + b

// void Triangle(int firstSide, int secondSide, int thirdSide)
// {
//     int [] sides = {firstSide, secondSide, thirdSide};
//     if (sides[0] < sides[1] + sides[2] && sides[1] < sides[0] + sides[2] && sides[2] < sides[0] + sides[1])
//         System.Console.WriteLine($"Треугольник существует");
//     else System.Console.WriteLine($"Не существует");
// }

// Triangle(3,4,5);

