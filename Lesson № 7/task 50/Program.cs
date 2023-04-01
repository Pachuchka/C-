//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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
string CheckElement(double [,] m)
{
	string st ="";
	int a = UserNumInput($"задайте координаты искомого элемента, строка:");
	int b = UserNumInput($"столбец:");
	if ((a<0)||(b<0))
	{
		st = "индексы должны быть положительными";
	}	
	else
	{
		if ((a>=m.GetLength(0))||(b>=m.GetLength(1)))
		{
			st = $"Элемента с индексами {a},{b} не существует";
		}	
		else 
		{
			st = Convert.ToString(m[a,b]);
		}
	}
	
return st;
}

double [,] matrix = CreatedoubleMatrix();
AssignRandomValues(matrix);
PrintArray(matrix);
Console.WriteLine(CheckElement(matrix));