int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    Console.WriteLine("Выводим все числа от 1 до куба заданного числа... ");
    return val;
}

void Cubing (int val)
{
    for (int count = 1; count < Math.Abs(val); count++)
    {
        Console.Write(Math.Pow(count, 3) + " ");
    }  
}
int num = Prompt("Введите число: ");
Cubing(num);