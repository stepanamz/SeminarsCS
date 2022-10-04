Console.Clear();
// Task24();
// Task26();
//Task28();
Task30();


// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

void Task24()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        
        Console.Write($"{sum += i} ");
    }
    Console.WriteLine($"\n{number} -> {sum} ");
}

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

void Task26()
{
    
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!); // 100
    int current = Math.Abs(number);
    int count = 0;

        while (current>0)
        {
            current = current / 10;
            count++;
        }



       Console.WriteLine($"В числе {number} -> {count} цифр");
   
}

// Задача 28: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

void Task28()
{
      Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        
        Console.WriteLine($"{sum} * {i} = {sum *= i} ");
    }
    Console.WriteLine($"\n{number} -> {sum} ");

}

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

void Task30()
{
    Console.WriteLine("Введите размер массива: ");
    int length = int.Parse(Console.ReadLine()!);

    int[] array = new int[length];
    FillArrayRandom(array);
    PrintArray(array);

    void FillArrayRandom(int[] array)
    {
        for (int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(0,2);
        }
    }

    void PrintArray(int[] array)
    {
        Console.Write("[");
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
                if (i == length - 1)
                    Console.WriteLine("]");
                else
                    Console.Write(", ");
            }
    }
    
}





