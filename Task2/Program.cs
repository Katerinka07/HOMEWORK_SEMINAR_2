/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int InputNum(string massege)
{
    Console.WriteLine(massege);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}
int number = InputNum("Введите целое число:");
int result = 0;
void NoThirdDigit(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
int ThirdDigit(int number)
{
    while (number > 999)
    {
        result = number /= 10;
    }
    result = number % 10;
    return result;
}

NoThirdDigit(number);
int thirdDigit = ThirdDigit(number);
Console.WriteLine($"Третья цифра {result}");
