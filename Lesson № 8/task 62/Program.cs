// Напишите программу, которая заполнит спирально массив 4 на 4. 
int[,] CreateSpiralZeroMatrix()
{
    int size = UserNumInput("Квадратную матрицу какого размера вы хотите создать?");
	int[,] m = new int[size,size];
    for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			m[i,j] = 0;
		}
	}
	return m;
}
void NextSlice(int [,] m,int slice,int limit, int value)
{
    if (m.GetLength(0)*m.GetLength(1)<limit)
    {
        limit=m.GetLength(0)*m.GetLength(1);
    }
    int rowStart = slice, rowEnd = m.GetLength(0) - (1+slice);
    int colStart = slice, colEnd = m.GetLength(1) - (1+slice);
    //заполняем верхнюю строку
    for (int i = colStart; i <= colEnd; i++)
    m[rowStart, i] = value++;

    // заполняем правый столбец
    for (int i = rowStart + 1; i <= rowEnd; i++)
    m[i, colEnd] = value++;

    // заполняем нижнюю строку
    for (int i = colEnd - 1; i >= colStart; i--)
    m[rowEnd, i] = value++;

    // заполняем левый столбец
    for (int i = rowEnd - 1; i >= rowStart + 1; i--)
    m[i, colStart] = value++;

    if (value<limit)
    {
        slice++;
        NextSlice(m,slice,limit,value); 
    }
}
int UserNumInput(string message)
{
   Console.WriteLine(message);
   string str = Console.ReadLine();
   int result = Convert.ToInt32(str);
   return result;
}
void PrintArray(int [,] m)
{
	string fmt = "00.##";
	for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			Console.Write($" {m[i,j].ToString(fmt)} ");
		}
	Console.WriteLine();
	}
}
int [,] matrix = CreateSpiralZeroMatrix();
int limit = UserNumInput("До какого значения вы хотите заполнить матрицу?");
NextSlice(matrix,0,limit,1);
PrintArray(matrix);