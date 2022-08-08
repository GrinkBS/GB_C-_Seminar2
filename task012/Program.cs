// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

if (number % a == 0 & number % b == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}