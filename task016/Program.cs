// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.Write("Понедельник");
        break;
    case 2:
        Console.Write("Вторник");
        break;
    case 3:
        Console.Write("Среда");
        break;
    case 4:
        Console.Write("Четверг");
        break;
    case 5:
        Console.Write("Пятница");
        break;
    case 6:
        Console.Write("Суббота");
        break;
    case 7:
        Console.Write("Воскресенье");
        break;
    default:
    Console.Write("Нет такого дня");
    break;
}
if (number > 0 & number <= 5)
{
    Console.WriteLine(" -> не выходной");
}
else if (number > 5 & number <= 7)
{
    Console.WriteLine(" -> выходной");
}
else
{
   Console.WriteLine(" -> введите число от 1 до 7"); 
}
 