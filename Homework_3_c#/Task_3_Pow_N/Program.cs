// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enmter number N: ");
int number = Convert.ToInt32(Console.ReadLine());
double answer = 0;

if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
        answer = Math.Pow(i, 3);  // возводит число i в степень указанную после запятой 
        System.Console.WriteLine(answer);

    }
}
else System.Console.WriteLine("Incorrect number");