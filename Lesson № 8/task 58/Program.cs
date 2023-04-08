//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void AssignRandomValues(int [,] m)
{
	var rand = new Random();
	for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			m[i,j] = rand.Next(1,10);
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
int [,] CreateIntMatrix()
{
	int a = UserNumInput($"Введите количество строк матрицы");
	int b = UserNumInput($"Введите количество столбцоы матрицы");
	int[,] matrix = new int[a,b];
	return matrix;
}
bool CheckMatrix (int [,] A, int [,] B)
{
    bool check = false;
    if (A.GetLength(1) == B.GetLength(0))
    { 
        check = true;
    }
    else
    {
        check = false;
    }
    return check;
}
int [,] MatrixMultiplay(int [,] A, int [,] B)
{
    int [,] result = new int[,] {{0,0},{0,0}};
    if (CheckMatrix(A,B) == true)
    {
    result = new int[A.GetLength(0),B.GetLength(1)];
    for (int i = 0 ;i<A.GetLength(0);i++)
    {
        for (int j = 0; j<B.GetLength(1);j++)
        {
            for (int k = 0 ;k<A.GetLength(1);k++)
            {
               result[i,j] = result[i,j] + A[i,k]*B[k,j];
            }
            
        }
    }
    }
    else
    {
        Console.WriteLine("Матрицы не совместимы");
        
    }
return result;
}

int [,] matrixA = CreateIntMatrix();
AssignRandomValues(matrixA);
int [,] matrixB = CreateIntMatrix();
AssignRandomValues(matrixB);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);

int[,] res = MatrixMultiplay(matrixA,matrixB);
Console.WriteLine();
if (CheckMatrix(matrixA,matrixB)==true)
{
    PrintArray(res);
}