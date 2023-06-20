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





// Дано натуральное число. Определить:

// а) количество цифр в нем;

int Col(int num)
{
    int length = 0;
    while (num >= 1)
    {
        num /= 10;
        length++;
    }
    return length;
}

// б) сумму его цифр;

int Summ(int num)
{
    int summ = 0;
    while (num >= 1)
    {
        summ += num % 10;
        num /= 10;
    }
    return summ;
}

// в) произведение его цифр;

int Proizv(int num)
{
    int pro = 1;
    while (num >= 1)
    {
        pro *= num % 10;
        num /= 10;
    }
    return pro;
}
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
// }

// г) среднее арифметическое его цифр;

int Avg(int num)
{
    int avg = Summ(num) / Col(num);
    return avg;
}

// д) сумму квадратов его цифр;

int SumQ(int num)
{
    int summ = 0;
    while (num >= 1)
    {
        summ += (num % 10) * (num % 10);
        num /= 10;
    }
    return summ;
}

// е) сумму кубов его цифр;

int SumQ2(int num)
{
    int summ = 0;
    while (num >= 1)
    {
        summ += (num % 10) * (num % 10) * (num % 10);
        num /= 10;
    }
    return summ;
}

// ж) его первую цифру;



// з) сумму его первой и последней цифр.

System.Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Колличество: {Col(userNum)}");
System.Console.WriteLine($"Сумма: {Summ(userNum)}");
System.Console.WriteLine($"Произведение: {Proizv(userNum)}");
System.Console.WriteLine($"Среднее арифметическое: {Avg(userNum)}");
System.Console.WriteLine($"Сумма квадратов: {SumQ(userNum)}");
System.Console.WriteLine($"Сумма кубов числа: {SumQ2(userNum)}");

// Определить минимальное число, большее 200, которое нацело делится на 17. 


//Найти максимальное из натуральных чисел, не превышающих 5000, которое нацело делится на 39

