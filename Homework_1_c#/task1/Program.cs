//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


System.Console.WriteLine("enter number1");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter number2");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if(a > b)
{
    max = a;
}
else
{
    max = b;
}
System.Console.WriteLine($"Max number is: {max}");

