﻿// ЗАДАЧА №2

// Вывод на экран квадратов чисел от 1 до N
// n = 5; n = 10; n =15

// РЕШЕНИЕ:

void PrintSquares (int limit)
{
    int i = 1;
    while(i <= limit)
    {
        Console.Write($"{i*i} ");
        i++;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);