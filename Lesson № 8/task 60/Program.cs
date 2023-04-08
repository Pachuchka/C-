// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] Create3DMatrix()
{
	int[,,] matrix = new int[2,2,2];
	return matrix;
}
void AssignRandomValues(int [,,] m)
{
	var rand = new Random();
    int [] num = new int[9];
    int count = 0;
    num[0] = rand.Next(10);
	for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			for (int k = 0; k<m.GetLength(2);k++)
		    {
                count = count + 1;
                num[count] = num[count-1] + rand.Next(10)+1;             
                m[i,j,k] = num[count];
            }
		}
	}
}
void PrintArray(int [,,] m)
{
	
	for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
            for (int k = 0; k<m.GetLength(1);k++)
		    {
			    Console.Write($" {m[i,j,k]} ({i},{j},{k})");
            }
		}
	Console.WriteLine();
	}
}
int[,,] myarray = Create3DMatrix();
AssignRandomValues(myarray);
PrintArray(myarray);