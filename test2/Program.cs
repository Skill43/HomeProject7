// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
Console.WriteLine("Введите два положительных числа: M и N.");
s:
int m = inputNumber("Введите M: ");
if (m < 0)
{
    Console.WriteLine("Ошибка!! \nВведено не положительное число! \nПопробуйте еще раз: ");
    goto s;
}
u:
int n = inputNumber("Введите N: ");
if (n < m)
{
    Console.WriteLine("Ошибка!! \nВведеное число должно быть больше М! \nПопробуйте еще раз: ");
    goto u;
}
System.Console.WriteLine(PrintSum(n, m));
int PrintSum(int n, int m)
{
    if (n == m) return n;
    else return m + PrintSum(n, m + 1);
}