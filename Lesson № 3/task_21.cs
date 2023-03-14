//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using System;
Console.WriteLine("Введите координаты первой точки - три числа, разделённых ;  например: 12;34;-32 x = 12 y = 34 z = -32");
string user_str = Console.ReadLine();
double[] A = Convert.ToDouble(user_strs.Split(';'));

bool check(string[] x)
{
    bool proverka = false;
    if (A.Length > 3) Console.WriteLine("вы ввели слишком много параметров");
    else
    {
        if (A.Length < 3) Console.WriteLine("вы ввели слишком мало параметров");
        else proverka = true;
    }
    return proverka;
}
double sq_dif(double a, double b)
{
    double dif = a-b;
    double sq = dif*dif;
    return dif;
}
if (check(A)==true)
{
    Console.WriteLine("Введите координаты второй точки - три числа, разделённых ;  например: 12;34;-32 x = 12 y = 34 z = -32");
    string user_str = Console.ReadLine();
    double[] B = Convert.ToDouble(user_strs.Split(';')); 
    if (check(B)==true)
    { 
        double dist = Math.Sqrt(sq_dif(A[0],B[0])+sq_dif(A[1],B[1])+sq_dif(A[2],B[2]));
        Console.WriteLine($"Расстояние равно: {dist}");
    } 
}
