﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();
int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
s:
int n = inputNumber("N = ");
int m=1;
if (n<m)
{
Console.WriteLine("Ошибка!! \nВведено не положительное число! \nПопробуйте еще раз: ");
goto s;
}
Console.WriteLine(NatNum(n,m));
int NatNum(int n, int m)
{
    if (n==m) return n;
    else 
    System.Console.Write($"{NatNum(n, m+1)}; ");
    return m; 
}
