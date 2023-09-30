// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
RandomNumbersArray(numbers);
Console.WriteLine("Содержание массива: ");
WriteArray(numbers);
int count = 0;

for (int n = 0; n < numbers.Length; n++)
if (numbers[n] % 2 == 0)
count++;

Console.WriteLine($"-> {count} чисел чётные");

void RandomNumbersArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void WriteArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}