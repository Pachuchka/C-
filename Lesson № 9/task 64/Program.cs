//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int UserNumInput(string message)
{
   Console.WriteLine(message);
   string str = Console.ReadLine();
   int result = Convert.ToInt32(str);
   return result;
}
string NaturalInRange(int n, string str)
{
    str = str + $", {Convert.ToString(n)}";
    if (n==1) return str;
    else return NaturalInRange(n-1,str);
}
int num = UserNumInput("Введите N:");

Console.WriteLine($"{num}: {num}{NaturalInRange(num-1,"")}");