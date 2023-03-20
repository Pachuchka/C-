// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
var rand = new Random();
//var randsize = new Random()
Console.WriteLine("Генерируем массив чисел");
int [] randarr = new int[rand.Next(20)];
for (int i=0;i<randarr.Length;i++)
{
int n = rand.Next(1,100);
randarr[i] = n;
}

int ArrMethod(int[] arr)
{
	int sum = 0;
	for (int i=0;i<arr.Length;i++)
	{
		if (i%2 != 0)
		{
			sum = sum + arr[i];
		}
	}
	return sum;
}
	
string ArrayPrint(int[] arr)
{
    string arrstr ="[";
    for (int i=0;i<arr.Length-1;i++)
    {
        arrstr = arrstr + Convert.ToString(arr[i])+ ", ";
  
    }
    arrstr = arrstr + Convert.ToString(arr[arr.Length-1])+ "]";
    return arrstr;
}

Console.WriteLine($"{string.Join(" ", randarr)} сумма элементов, стоящих на нечётных позициях.  -> {ArrMethod(randarr)}");
