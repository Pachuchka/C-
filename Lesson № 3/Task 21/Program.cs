//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using System;

bool check(string[] x)
{
    bool proverka = false;
    if (x.Length > 3) Console.WriteLine("вы ввели слишком много параметров");
    else
    {
        if (x.Length < 3) Console.WriteLine("вы ввели слишком мало параметров");
        else proverka = true;
    }
    return proverka;
}
double sq_dif(double a, double b)
{
    double dif = a-b;
    double sq = Math.Pow(dif,2);
    return sq;
}
double[] ConvetrMass(string[] a)
{
    double [] elements = new double[a.Length];
    for (int i=0;i<a.Length;i++)
    {
        elements[i] = Convert.ToDouble(a[i]);
    }
    return elements;
}

Console.WriteLine("Введите координаты первой точки - три числа, разделённых ;  например: 12;34;-32 x = 12 y = 34 z = -32");
string user_str = Console.ReadLine();
string[] A = user_str.Split(';');

if (check(A)==true)
{
    Console.WriteLine("Введите координаты второй точки - три числа, разделённых ;  например: 12;34;-32 x = 12 y = 34 z = -32");
    string user_str_2 = Console.ReadLine();
    string[] B = user_str_2.Split(';'); 
    if (check(B)==true)
    { 
        double[] dA = ConvetrMass(A);
        double[] dB = ConvetrMass(B);
        Console.WriteLine($"A: {A}");
        Console.WriteLine($"B: {B}");
        Console.WriteLine($"dA: {dA}");
        Console.WriteLine($"dB: {dB}");
        Console.WriteLine(sq_dif(dA[0],dB[0]));
        Console.WriteLine(sq_dif(dA[1],dB[1]));
        Console.WriteLine(sq_dif(dA[2],dB[2]));
        double dist = Math.Sqrt(sq_dif(dA[0],dB[0])+sq_dif(dA[1],dB[1])+sq_dif(dA[2],dB[2]));
        Console.WriteLine($"Расстояние равно: {dist}");
    } 
}
