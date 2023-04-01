//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void AssignRandomValues(double [,] m)
{
	var rand = new Random();
	for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			m[i,j] = rand.NextDouble();
		}
	}
}
void PrintArray(double [,] m)
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
double [,] CreatedoubleMatrix()
{
	int a = UserNumInput($"Введите количество строк матрицы");
	int b = UserNumInput($"Введите количество столбцоы матрицы");
	double[,] matrix = new double[a,b];
	return matrix;
}
double [,] matrix = CreatedoubleMatrix();
AssignRandomValues(matrix);
PrintArray(matrix);