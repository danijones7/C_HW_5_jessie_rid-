//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("enter number1");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter number2");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter number3");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(a > b && a > c)
{
    max = a;
}
else if(b > a && b > c)
{
    max = b;
}
else if(c > a && c > b)
{
    max = c;
}
System.Console.WriteLine($"Max number is: {max}");

