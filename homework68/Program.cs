﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите положительное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите положительное число N: ");
int n = int.Parse(Console.ReadLine()!);
AckermannFunction(m,n);

void AckermannFunction(int m, int n)
{
    Console.Write(Ack(m, n)); 
}

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return (Ack(m - 1, Ack(m, n - 1)));
    }
}