//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void AssignRandomValues(int [,] m)
{
	var rand = new Random();
	for (int i = 0; i<m.GetLength(0);i++)
	{
		for (int j = 0; j<m.GetLength(1);j++)
		{
			m[i,j] = rand.Next(100);
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
int [,] CreatedoubleMatrix()
{
	int a = UserNumInput($"Введите количество строк матрицы");
	int b = UserNumInput($"Введите количество столбцоы матрицы");
	int[,] matrix = new int[a,b];
	return matrix;
}

static void Sort(int [,] m)
        {
            Console.WriteLine("Результат сортировки: ");
            int[] myint = new int[m.GetLength(1)];
            for (int i=0;i<m.GetLength(0);i++)
            {
                for (int j=0;j<m.GetLength(1);j++)
                {
                    myint[j] = m[i,j];
                }
                //WriteArray(myint);
                ShakerSort(myint);
                WriteArray(myint);
            }
            Console.ReadLine();
        }

        /* Шейкер-сортировка */
        static void ShakerSort(int[] myint)
        {
            int left = 0,
                right = myint.Length - 1,
                count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] > myint[i + 1])
                        Swap(myint, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] > myint[i])
                        Swap(myint, i - 1, i);
                }
                left++;
            }
            //Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());
        }

        /* Поменять элементы местами */
        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }

        /*Вывести массив*/
        static void WriteArray(int[] a)
        {
            foreach (int i in a)
                Console.Write("{0}  ", i.ToString());
            Console.WriteLine();
        }

int [,] matrix = CreatedoubleMatrix();
AssignRandomValues(matrix);
PrintArray(matrix);
Sort(matrix);