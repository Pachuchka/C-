// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int UserNumInput(string message)
{
   Console.WriteLine(message);
   string str = Console.ReadLine();
   int result = Convert.ToInt32(str);
   return result;
}
int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i=0;i<array.Length;i++)
    {
        array[i] = UserNumInput($"Введите {i+1}-й элемент");
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int length = UserNumInput("Массив какой длинны необходимо создать?");
int[] array =  CreateArray(length);
Console.WriteLine($"{string.Join(" ", array)} содержит {PositiveNumbers(array)} положительных значений");