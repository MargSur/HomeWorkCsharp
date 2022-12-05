/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Please enter number 1 : ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Please enter number 2 : ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("number 1 > number 2");
}
else if (number1 < number2)
{
    Console.WriteLine("number 2 > number 1");
}
else
{
    Console.WriteLine("number 2 = number 1");
}

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


Console.Write("enter the 1st number : ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("enter the 2nd number : ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("enter the 3rd number : ");
int number3 = int.Parse(Console.ReadLine());

int max =number1;

if (max<number2)
{
    max = number2;
}
if (max< number3)
{
    max = number3;
}
Console.WriteLine($"Max = {max}");