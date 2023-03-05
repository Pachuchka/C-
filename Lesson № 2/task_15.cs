using System;
string st;
Сonsole.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Сonsole.WriteLine("Введите целое число от 1 до 7");
st = Console.ReadLine();
int num = Convert.ToInt32(st);
If (num > 7)
{
    Console.WriteLine("введено слишком большое число");
}
else
{
    if (num<1)
    {
       Console.WriteLine("введено слишком маленькое число"); 
    }
    else
    {
            flag = num % 7
            if flag >5
            {
                Console.WriteLine("это выходной");     
            }
            else
            {
                Console.WriteLine("это не выходной"); 
            }
    }
    
}