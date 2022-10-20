// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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
    Console.WriteLine($"A(m,n) = {FunctionA(m, n)}");
}

int FunctionA(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return FunctionA(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return FunctionA(m - 1, FunctionA(m, n - 1));
    }
    return FunctionA(m, n);
}