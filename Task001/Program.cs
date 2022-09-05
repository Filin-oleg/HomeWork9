//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


Console.Clear();
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintNumber(int m, int n)
{
    if (m > n)
    { return; }
    else
    {
        Console.Write($"{m}, ");
        PrintNumber(m + 1, n);
    }
}
Console.WriteLine("Эта программа выводит все натуральные числа в промежутке от первого заданного Вами числа до второго заданного Вами числа");
PrintNumber(m, n);