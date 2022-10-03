Console.Clear();
//Task17();
//Task18();
//Task21();
//Task22();

// 17. Напишите программу, которая принимает на вход координаты точки (Х и Y), 
// причём X # 0 и Y # 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
void Task17()
{


    Console.Write("Введите координаты точки X: ");
    int x = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки Y: ");
    int y = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Задана точка А({x};{y}) ");

    CoordCheck(x, y);
}

void CoordCheck(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Точка находится на одной из осей. Введите другие значения.");
    }
    else
    {
        if (x > 0 & y > 0)
        {
            Console.WriteLine("Вы находитесь в 1 четверти");
        }
        else if (x < 0 & y > 0)
        {
            Console.WriteLine("Вы находитесь в 2 четверти");
        }
        else if (x < 0 & y < 0)
        {
            Console.WriteLine("Вы находитесь в 3 четверти");
        }
        else
        {
            Console.WriteLine("Вы находитесь в 4 четверти");
        }
    }
}

// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (х и у)
void Task18()
{

    Console.Write("Введите номер четверти: ");
    int num = int.Parse(Console.ReadLine()!);

    DiaposonCheck(num);
}

void DiaposonCheck(int num)
{
    if (num == 1)
    {
        Console.Write("Первая четверть - (x>0 ; y>0) ");
    }
    else if (num == 2)
    {
        Console.Write("Вторая четверть - (x<0 ; y>0) ");
    }
    else if (num == 3)
    {
        Console.Write("Третья четверть - (x<0 ; y<0) ");
    }
    else if (num == 4)
    {
        Console.Write("Четвертая четверть - (x>0 ; y<0) ");
    }
    else
    {
        Console.Write($"Четверти {num} не существует. Попробуй еще раз.");
    }
}

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

void Task21()
{
    Console.Write("Введите AX: ");
    int ax = int.Parse(Console.ReadLine()!);
    Console.Write("Введите AY: ");
    int ay = int.Parse(Console.ReadLine()!);
    Console.Write("Введите BX: ");
    int bx = int.Parse(Console.ReadLine()!);
    Console.Write("Введите BY: ");
    int by = int.Parse(Console.ReadLine()!);

    Console.Write($"A ({ax},{ay}); B ({bx},{by}) ->  {rast(ax, ay, bx, by)}");
}

double rast(int ax, int ay, int bx, int by)
{
    return Math.Round(Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)), 2);

}


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void Task22()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    TableKvadrat(number);
}

void TableKvadrat(int number)
{
    double count = 0;
    for (int i = 1; i <= number; i++)
    {
        count = Math.Pow(i, 2);
        Console.WriteLine($"| {i} | {count} |");
    }

}