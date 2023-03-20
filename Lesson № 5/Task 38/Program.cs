// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
var rand = new Random();
//var randsize = new Random()
Console.WriteLine("Генерируем массив чисел");
double [] randarr = new double[rand.Next(20)];
for (int i=0;i<randarr.Length;i++)
{
double n = rand.Next(-100,100);
randarr[i] = n;
}

double ArrMax(double[] arr)
{
	double max = arr[0];
	for (int i=0;i<arr.Length;i++)
	{
		if (max<arr[i])
		{
			max = arr[i];
		}
	}
	return max;
}
double ArrMin(double[] arr)
{
	double min = arr[0];
	for (int i=0;i<arr.Length;i++)
	{
		if (min>arr[i])
		{
			min = arr[i];
		}
	}
	return min;
}
double amax = ArrMax(randarr);
double amin = ArrMin(randarr);
double result = amax-amin;
	
string ArrayPrint(double[] arr)
{
    string arrstr ="[";
    for (int i=0;i<arr.Length-1;i++)
    {
        arrstr = arrstr + Convert.ToString(arr[i])+ ", ";
  
    }
    arrstr = arrstr + Convert.ToString(arr[arr.Length-1])+ "]";
    return arrstr;
}

Console.WriteLine($"{ArrayPrint(randarr)} -> {result} (разница между максимальным и минимальным элементов массива)");