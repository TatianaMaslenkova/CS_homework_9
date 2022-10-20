// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.WriteLine("Введите положительное число: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 1)
{
    Console.WriteLine("Введите положительное число!");
}
else
{
    ArrayNTo1(n);
}

void ArrayNTo1(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} ");
        ArrayNTo1(n - 1);
    }
}