// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N. Выполнить с помощью рекурсии.
int UserNumInput(string message)
{
   Console.WriteLine(message);
   string str = Console.ReadLine();
   int result = Convert.ToInt32(str);
   return result;
}
int SumInRange(int m, int n, int s)
{
    s=s+m;
    if (m==n) return s;
    else return SumInRange(m+1, n, s);
}
int m = UserNumInput("Введите M:");
int n = UserNumInput("Введите N:");
Console.WriteLine($"M: {m} N: {n}; Sum: {SumInRange(m,n,0)}");

