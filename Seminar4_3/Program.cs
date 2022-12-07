/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
 */


 Console.WriteLine("Введите число:");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {limit} равно {PR(limit)}");

int PR (int limit)
{
    int PR = 1;
    for (int i = 1; i<= limit; i++)
        PR *= i;
        return PR;
}
