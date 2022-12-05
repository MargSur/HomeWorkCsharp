// Задача


var random = new Random();

int randomNum = random.Next(10, 100);

System.Console.WriteLine(randomNum);

int num1 = randomNum / 10;

int num2 = randomNum % 10;

if (num1 > num2)
{
    System.Console.WriteLine(num1);
}
else if (num1 < num2)
{
    System.Console.WriteLine(num2);
}
else
{
    System.Console.WriteLine("Они равны");
}