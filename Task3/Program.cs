/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int DayWeek(string massege)
{
    Console.WriteLine(massege);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}
int number = DayWeek("Введите число от 1 до 7:");
if (number < 1 || number > 7)
    Console.WriteLine("Такого дня недели нет");
else
{
    if (number > 5)
        Console.WriteLine("Ура, выходной день!");
    else
        Console.WriteLine("Рабочий день");
}
