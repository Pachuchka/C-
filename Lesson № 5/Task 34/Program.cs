// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
var rand = new Random();
//var randsize = new Random()
Console.WriteLine("Генерируем массив чисел");
int [] randarr = new int[rand.Next(20)];
for (int i=0;i<randarr.Length;i++)
{
int n = rand.Next(100,999);
randarr[i] = n;
}

int[] ArrMethod(int[] arr)
{
	int[] result = new int[0];
	int j = -1;
	for (int i=0;i<arr.Length;i++)
	{
		if (arr[i]%2 == 0)
		{
			j=j+1;
			Array.Resize(ref result, result.Length+1);
			result[j] = arr[i];
		}
	}
	return result;
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

Console.WriteLine($"{string.Join(" ", randarr)} Содержит чётные значения -> {ArrayPrint(ArrMethod(randarr))}");
Console.WriteLine($"{string.Join(" ", randarr)} Содержит {ArrMethod(randarr).Length} чётных значений");
