// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N. Рекурсивно
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// 1-й вариант: поместить 2 рекурсии в 1 метод:

Console.Clear();

Console.Write("Введите первое положительное число: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе положительное число: ");
int n = int.Parse(Console.ReadLine()!);

if ((m < 1) || (n < 1))
{
    Console.WriteLine("Введите положительные числа!");
}

else
{
    int sumMN = SumMNOrNM(m, n);
    Console.WriteLine(sumMN);
}

int SumMNOrNM(int m, int n)
{
    if (m <= n)
    {
        if (m - n == 0)
            return m;
        else
            return m + SumMNOrNM(m + 1, n);
    }
    else
    {
        if (n - m == 0)
            return n;
        else
            return n + SumMNOrNM(m, n + 1);
    }
}


// 2-й вариант: поместить 2 рекурсии в 2 метода:
// Console.Clear();

// Console.Write("Введите первое положительное число: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе положительное число: ");
// int n = int.Parse(Console.ReadLine()!);

// if ((m < 1) || (n < 1))
// {
//     Console.WriteLine("Введите положительные числа!");
// }

// else if (m > n)
// {
//     int sumNToM = ArraySumNToM(m, n);
//     Console.WriteLine(sumNToM);
// }

// else
// {
//     int sumMToN = ArraySumMToN(m, n);
//     Console.WriteLine(sumMToN);
// }

// int ArraySumMToN(int m, int n)
// {
//     int sum = 0;
//     if (m <= n)
//     {
//         if (m - n == 0)
//         {
//             sum += m;
//         }
//         else
//         {
//             sum += m + ArraySumMToN(m + 1, n);
//         }
//     }
//     return sum;
// }

// int ArraySumNToM(int m, int n)
// {
//     int sum = 0;
//     if (n <= m)
//     {
//         if (n - m == 0)
//         {
//             sum += n;
//         }
//         else
//         {
//             sum += n + ArraySumNToM(m, n + 1);
//         }
//     }
//     return sum;
// }