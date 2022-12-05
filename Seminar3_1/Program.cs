/* Напишите программу, которая по заданному номеру
четверти, показывает диапазон возможных координат
точек в этой четверти (x и y). */

Console.Write("enter the quarter: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
{
Console.WriteLine("x>0, y>0");
}
else if (quarter == 2)
{
    Console.WriteLine("x<0, y>0");
}
else if (quarter == 3)
{
    Console.WriteLine("x<0, y<0");
}
else if (quarter == 4)
{
    Console.WriteLine("x>0, y<0");
}
else if (quarter > 4)
{
    Console.WriteLine("no exist");
}