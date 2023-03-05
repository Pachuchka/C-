Console.WriteLine("Введите целое трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
If (num > 1000)
{
    Console.WriteLine("введено слишком большое число");
else
{
    if (num<100)
    {
       Console.WriteLine("введено слишком маленькое число"); 
       else
       {
            num = num/10
            num = num %10
            Console.WriteLine("вторая цифра числа - {num}");
       }
    }
}
}
