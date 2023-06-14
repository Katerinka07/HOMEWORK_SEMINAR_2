/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int InputNum(string massege)
{
    Console.WriteLine(massege);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}
int number = InputNum("Введите трехзначное число:");
if (number < 100 || number > 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
    return;
}
int TwoDigits = number / 10 % 10;
Console.WriteLine($"Вторая цифра: {TwoDigits}");
