using System;
string st;
Сonsole.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Сonsole.WriteLine("Введите целое трёхзначное число");
st = Console.ReadLine();
int num = Convert.ToInt32(st);
If (num > 1000)
{
    Console.WriteLine("введено слишком большое число");
}
else
{
    if (num<100)
    {
       Console.WriteLine("введено слишком маленькое число"); 
    }
    else
    {
            num = num/10;
            num = num %10;
            Console.WriteLine($"вторая цифра числа - {num}");
    }
    
}