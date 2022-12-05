// Задача №1. Напишите программу, которая на вход принимает два числа и сравнивает, 
// является ли первое число квадратом второго

Console.Write("Введите число 1: ");
string s_num1 = Console.ReadLine();
Console.Write("Введите число 2: ");
string s_num2 = Console.ReadLine();

int num1 = Convert.ToInt32(s_num1);
int num2 = Convert.ToInt32(s_num2);

int sqr;

if (num1 > num2)
{
    sqr = num2 * num2;
    if (sqr == num1)
        Console.WriteLine("Да, является");
    else
    {
        Console.WriteLine("Нет, не является");
    }
}
else
{
    sqr = num1 * num1;
    if (sqr == num2)
        Console.WriteLine("Да, является");
    else
    {
        Console.WriteLine("Нет, не является");
    }
}

/* if (num1==num2*num2)
    Console.WriteLine ("Первое число является квадратом второго");
else
    Console.WriteLine("Первое числе не является квадратом второго"); */