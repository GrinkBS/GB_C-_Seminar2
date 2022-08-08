// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число A: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberb = Convert.ToInt32(Console.ReadLine());
int res = numbera % numberb;

if (res == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {res}");
}