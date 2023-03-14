// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите целое пятизначное число");
string user_str = Console.ReadLine();
int user_num = Convert.ToInt32(user_str);
bool flag = true;
if (user_num < 10000 | user_num > 99999) Console.WriteLine("Вы ввели не корректное число");
else
{
    char[] c = user_str.ToCharArray();
    for (int i = 0; i <=c.Length/2;i++)
    {
        if (c[i] != c[c.Length-(i+1)])
        {
            flag = false;
        }
    }
    if (flag == true)
        {
            Console.WriteLine("это палиндром");
        }
    else 
        {
            Console.WriteLine("это не палиндром");
        }
}