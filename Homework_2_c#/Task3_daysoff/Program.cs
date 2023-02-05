//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.WriteLine("Введи номер");
int daynumber = Convert.ToInt32(Console.ReadLine());
if (daynumber == 6 || daynumber == 7 )
{
System.Console.WriteLine("Ура, выходной!)");
}
else if (daynumber == 1 || daynumber == 2 || daynumber == 3 || daynumber == 4 || daynumber == 5)
{
System.Console.WriteLine("Прости, дружок, НЕ выходной. Иди на работу!)");
}
else System.Console.WriteLine("Тебе и правда очень нужен выходной. Такого дня вообще нет:/");