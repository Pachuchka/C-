using System;
string st;
Сonsole.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Сonsole.WriteLine("Введите целое число");
st = Console.ReadLine();
int num = Convert.ToInt32(st);
If (num <100>)
{
    Console.WriteLine("третьей цифры нет");
}
    else
    {
        num = num%1000;
        num = num/100;
        Console.WriteLine($"третья цифра числа - {num}");
    }