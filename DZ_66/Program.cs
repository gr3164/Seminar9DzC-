// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Программа выведит сумму элементов от M до N.");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

int sum = 0;
Console.WriteLine("Сумма элементов: ");
Console.Write($"M = {M}; N = {N} ->  ");
SumNumbers(M, N, sum);

void SumNumbers(int M, int N, int sum)
{
    sum += (M++);
    if (M > N)
    {
        Console.WriteLine(sum);
        return;
    }
    SumNumbers(M, N, sum);
}

