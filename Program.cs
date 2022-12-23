Console.Clear();
Console.WriteLine("Задача 1: показать вторую цифру трехзначного числа.");
Console.WriteLine("Мвтематически: ");
int num = new Random().Next(100, 1000);
int secondnumber = num /10 % 10;
Console.WriteLine($"Вторая цифра в числе {num} -> {secondnumber}");

Console.WriteLine("Строково: ");
Console.Write("Введи трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
string Num = Convert.ToString(number);
if(Num.Length == 3)
{
    Console.WriteLine($"Вторая цифра в числе {number} -> {Num[1]}");
}
else{
    Console.WriteLine($"Введено неверное число");
}