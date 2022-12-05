/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("type Num: ");
int Num = Convert.ToInt32(Console.ReadLine());
int i = 2;

Console.WriteLine("Четные числа от 1 до " + Num);
while (i <= Num)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i += 2;
}