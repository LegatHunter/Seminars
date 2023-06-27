// Вычислите сумму членов последовательности, начинающейся с единицы, 
// в которой каждый следующий член в три раза больше предыдущего,
// т.е. {1, 3, 9, 27, 81,…}, причем последний член последовательности не должен превышать 1000.

void PrintArray(int [] printArray)
{
    for(int i = 0; i < printArray.Length; i++)
    {
    System.Console.Write($"{printArray[i]}");
    if(i != printArray.Length - 1) System.Console.Write(", ");
    else System.Console.Write(".");
    }
}

int [] Posled(int size)
{
    int s;
    int [] posl = new int [size];
    for (int i = 0; i < size; i++)
    {
        s = posl[i] * 3;
    }
    return posl;
}

int [] a = Posled();
PrintArray(a);

// Сформируйте массив целых чисел по алгоритму Фибоначчи: 
// 1-й и 2-й элемент равны 1, а каждый последующий равен сумме двух предыдущих, 
// т.е.: 1, 1, 2, 3, 5, 8, … . Найдите сумму и произведение его N членов.

// void PrintArray(int [] printArray)
// {
//     for(int i = 0; i < printArray.Length; i++)
//     {
//         System.Console.Write($"{printArray[i]}");
//         if(i != printArray.Length - 1) System.Console.Write(", ");
//         else System.Console.Write(".");
//     }
// }

// int [] Feb(int size)
// {
//     int [] feb = new int [size];
//     feb[0] = 1;
//     feb[1] = 1;
//     for (int i = 2; i < size; i++)
//     {
//         feb[i] = feb[i - 1] + feb[i - 2];
//     }
//     return feb;
// }

// int Summ(int [] array)
// {
//     System.Console.WriteLine("Введите число: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     for(int i = 0; i < n; i++)
//     {
//         array[i] = array[i+1];
//     }
//     return ;
// }

// System.Console.WriteLine("Введите размер массива: ");
// int s = Convert.ToInt32(Console.ReadLine());
// int [] a = Feb(s);
// PrintArray(a);


// Задан массив целых чисел A[20]. Создать другой массив целых чисел B[ ], 
// в который войдут все числа исходного массива, 
// удовлетворяющие условию: А[i] <= 888, после чего отсортировать элементы массива В[ ] по убыванию




// Задано три треугольника со своими сторонами (a, b, c). 
// Найти треугольник с наибольшим периметром или наибольшей площадью. 
// Всегда ли это будет один и тот же треугольник?