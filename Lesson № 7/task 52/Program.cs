//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void AssignRandomValues(int [,] m)
{
	var rand = new Random();
	for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			m[i,j] = rand.Next(1,100);
		}
	}
}
void PrintArray(int [,] m)
{
	var rand = new Random();
	for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			Console.Write($" {m[i,j]} ");
		}
	Console.WriteLine();
	}
}
int UserNumInput(string message)
{
   Console.WriteLine(message);
   string str = Console.ReadLine();
   int result = Convert.ToInt32(str);
   return result;
}
int[,] CreateIntMatrix()
{
	int a = UserNumInput($"Введите количество строк матрицы");
	int b = UserNumInput($"Введите количество столбцоы матрицы");
	int[,] matrix = new int[a,b];
	return matrix;
}
double [] SredneeArifmetic(int [,] m)
{
    double [] result = new double[m.GetLength(1)];
    int sum=0;
    for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			result[j] = result[j] + m[i,j];
		}
    }
    for (int i = 0; i<m.GetLength(1);i++)
    {
        result[i]=result[i]/m.GetLength(0);
    }
    return result;
}
int[,] matrix = CreateIntMatrix();
AssignRandomValues(matrix);
PrintArray(matrix);
var str = string.Join(" ", SredneeArifmetic(matrix));
Console.WriteLine(str );
