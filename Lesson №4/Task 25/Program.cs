// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число, которое нужно будет возвести в степень:");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("В какую степень нужно возвести?:");
int B = Convert.ToInt32(Console.ReadLine());
double Func(double A, int B)
{
    double result = A;
    int i=1;
    while (i<B)
    {
       result =  result*A;
       i++;
    }
    return result;
}
if (B==0)
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine($" {A} ^ {B} -> {Func(A,B)}");
}