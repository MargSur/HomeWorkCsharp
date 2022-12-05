/* Задача №21. Работа в группах
Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между
ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21
 */

 Console.WriteLine("Введите x точки a: ");
 Console.WriteLine("Введите y точки a: ");
 Console.WriteLine("Введите x точки b: ");
 Console.WriteLine("Введите y точки b: ");

 int xa = int.Parse(Console.ReadLine());
 int ya = int.Parse(Console.ReadLine());
 int xb = int.Parse(Console.ReadLine());
 int yb = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2));

System.Console.WriteLine(result);

