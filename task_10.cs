int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int num = Prompt("Введите целое трёхзначное число");

If (num > 1000)
{
    Console.WriteLine("введено слишком большое число");
}
else
{
    if (num<100)
    {
       Console.WriteLine("введено слишком маленькое число"); 
    }
    else
    {
            num = num/10;
            num = num %10;
            Console.WriteLine($"вторая цифра числа - {num}");
    }
    
}