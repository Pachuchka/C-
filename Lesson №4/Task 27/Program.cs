// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите целое число, сумму цифр которого нужно сосчитать");
int N = Convert.ToInt32(Console.ReadLine());
if (N <0) N=Convert.ToInt32(Math.Sqrt(N*N));
int Method(int A)
{    
    int sum = 0;
    while (A/10>=1)
    {       
        sum = sum + Convert.ToInt32(A%10);
        A=A/10;    
    }
    return sum+A;
}
Console.WriteLine($"сумма цифр числа {N} равна {Method(N)}");