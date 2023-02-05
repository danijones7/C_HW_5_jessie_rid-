//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

System.Console.WriteLine("enter number");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{ System.Console.WriteLine("Yes, the number is even"); }
else
{
    System.Console.WriteLine("No, the number is odd");
}

