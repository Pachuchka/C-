//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
void MinSumLine(int [,] m)
{
    int [] result = new int[m.GetLength(0)];
    int sum=0;
    for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			result[i] = result[i] + m[i,j];
		}
    }
    Console.WriteLine($"строка с минимальной суммой значений: {MinEl(result)}"); 
}
int MinEl(int [] m)
{
    int min = m[0];
    int count = 0;
    for (int i = 0; i < m.Length; i++)
    {
        if (m[i]<min)
        {
            min = m[i];
            count = i;
        }
    }
    return count;
}
int[,] matrix = CreateIntMatrix();
AssignRandomValues(matrix);
PrintArray(matrix);
MinSumLine(matrix);

