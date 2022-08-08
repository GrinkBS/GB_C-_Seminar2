// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число A: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberb = Convert.ToInt32(Console.ReadLine());
int res1 = numbera * numbera;
int res2 = numberb * numberb;

if (res1 == numberb)
{
    Console.WriteLine("да");
}
else if (res2 == numberb)
{
    Console.WriteLine("да");
}
else
{
Console.WriteLine("нет");
}