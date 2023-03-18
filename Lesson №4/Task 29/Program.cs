// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
var rand = new Random();
Console.WriteLine("Генерируем массив чисел");
int [] randarr = new int[8];
for (int i=0;i<8;i++)
{
int n = rand.Next(100);
randarr[i] = n;
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
Console.WriteLine($"{string.Join(" ", randarr)} -> {ArrayPrint(randarr)}");