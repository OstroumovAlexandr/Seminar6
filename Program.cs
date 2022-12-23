/*
Console.Clear();
Console.WriteLine("Задача 1: показать вторую цифру трехзначного числа.");
Console.WriteLine("Мвтематически: ");
int num = new Random().Next(100, 1000);
int secondnumber = num /10 % 10;
Console.WriteLine($"Вторая цифра в числе {num} -> {secondnumber}");

Console.WriteLine("Строково: "); //  в строках могут и числа и буквы
Console.Write("Введи трехзначное число: ");
int number = int.Parse(Console.ReadLine()!); // поэтому преобразуем введенные значения в цифры
string Num = Convert.ToString(number); // 1-ый способ КОНВЕРТИРОВАНИЯ переменной "int number" в "string number"
if(Num.Length == 3)
{
    Console.WriteLine($"Вторая цифра в числе {number} -> {Num[1]}");
}
else{
    Console.WriteLine($"Введено неверное число");
}
*/



// домашяя задача с прошлого семинара по выводу третьей цифры числа (от 100 до 100000)
/*
Console.Clear();
Console.WriteLine("Строково:");
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine()!);
string Number = num2.ToString(); // 2-ой способ КОНВЕРТИРОВАНИЯ "int num2" в "string num2"
if(Number.Length > 5)
{
    Console.WriteLine($"Число введено неверно!");
}
else if(Number.Length < 3){
    Console.WriteLine("Третьей цифры нет!");
}
else {
    Console.WriteLine($"Третья цифра числа {num2} -> {Number[2]}");
}

*/





//показали что можно использовать конструкцию SWITCH CASE
/*
Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
switch (num)   // в скобках () указано что мы сравниваем
{
case(1):{                              //в скобках () указано с чем мы сравниваем
Console.WriteLine("Это понедельник"); // если совпадает прописываем, что мы делаем
break;                               // после чего ОБЯЗАТЕЛЬНО останавливаем выполнение
}
case(2):{
    Console.WriteLine("Это вторник");
break;
}
    default:{                  // если ничего не совпало со сравниваемым, то ...
        Console.WriteLine("Ошибка!!!");
    break;
    }
}

*/




//  Определение четврети плоскости координат в зависимости от введенных координат
/*
Console.WriteLine("Введи Х: ");
int X = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введи Y: ");
int Y = int.Parse(Console.ReadLine()!);

if(X > 0 && Y > 0)
{
    Console.WriteLine("Это первая четверть.");
}

if(X < 0 && Y > 0)
{
    Console.WriteLine("Это вторая четверть.");
}
if(X < 0 && Y < 0)
{
    Console.WriteLine("Это третья четверть.");
}
if(X > 0 && Y < 0)
{
    Console.WriteLine("Это четвертая четверть.");
}

*/




// Очередная задача на Семинаре 6
/*
Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

switch (num)
{
    case 1: {
        Console.WriteLine("X > 0, Y > 0");
        break;
    }
    case 2: {
        Console.WriteLine("X < 0, Y > 0");
        break;
    }
    case 3: {
        Console.WriteLine("X < 0, Y < 0");
        break;
    }
    case 4: {
        Console.WriteLine("X > 0, Y < 0");
        break;
    }
    default: {
        Console.WriteLine("Такой четверти не существует");
        break;
    }
}

*/



// Нахождене расстояния между двумя точками в 2D простарнстве

Console.WriteLine("Введите координату Х точки А: ");
int xa = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Х точки B: ");
int xb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки А: ");
int ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки B: ");
int yb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2));

Console.WriteLine($"Расстояние между точками: {result:f2}"); // {result:f2} после двоеточия стоит конструкция, 
                                                            // которая определяет количество выводимых знаков после запятой. 
                                                           // 2 - означает два знака

