// Задача 8: Напишите программу, которая на вход принимает число
//  (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Формулу взял с интернета :) В математике не силен)

Console.WriteLine("Введите число от 1 ");
int number = int.Parse(Console.ReadLine());
string s = "";

while (number < 1)
{
    Console.Write("Вы ошиблись!Введите число от 1: ");
    number = int.Parse(Console.ReadLine());
}

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0) 
        s = s + ($"{i } ");
}

Console.WriteLine($"{number} -> {s} ");