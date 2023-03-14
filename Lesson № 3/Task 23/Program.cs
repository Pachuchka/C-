// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите целое число");
int user_num = Convert.ToInt32(Console.ReadLine());
double [] user_mass = new double[user_num];
for (int i=0;i<user_num;i++)
{
    user_mass[i] = Math.Pow(i+1,3);
    Console.WriteLine(user_mass[i]);
    
}
