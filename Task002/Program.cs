// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintSumm(int m, int n, int summ)
{
    summ += n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных элементов в промежутке от первого числа до второго числа = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}
int summ = 0;
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, summ);
