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