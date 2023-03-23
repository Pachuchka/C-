// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double UserNumInput(string message)
{
   Console.WriteLine(message);
   string str = Console.ReadLine();
   double result = Convert.ToDouble(str);
   return result;
}
double [] LineParam(int length)
{
    double[] array = new double[length];
    for (int i=0;i<array.Length;i++)
    {
        array[i] = UserNumInput($"Введите {i+1}-й элемент");
    }
    return array;
}

double [] LineIntersection(double [] a, double [] b)
{
    double [] result = new double[2];
    double [] c = new double[2];
    c[0] = a[0]-b[0];
    c[1] = a[1]-b[1];
    result[0] = -1*c[1]/c[0];
    result[1] = result[0]*a[0]+a[1];
    return result;
}
int length = 2;
Console.WriteLine("в уравнении вида y=kx+b; 1-й элемент - это k второй элемент - это b");
double [] a = LineParam(length);
double [] b = LineParam(length);
Console.WriteLine($" точкой пересечения линий y={a[0]}*x + {a[1]} и y={b[0]}*x + {b[1]} является точка ({LineIntersection(a,b)[0]},{LineIntersection(a,b)[1]})");