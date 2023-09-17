// Нипишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78->8
// 12->2
// 85->8

int num = new Random ().Next(10,100);
Console.WriteLine(num);
int num1 = new Random ().Next(10,100);
Console.WriteLine(num1);
int num2 = new Random ().Next(10,100);
Console.WriteLine(num2);

FindMaxDigit(num);
FindMaxDigit(num1);
FindMaxDigit(num2);

void FindMaxDigit(int number)
{
int digit1=number / 10;
int digit2=number % 10;
Console.WriteLine($"{digit1}, {digit2}");
if (digit1>digit2) Console.WriteLine(digit1);
else if (digit1==digit2) Console.WriteLine("Цифры равны");
else Console.WriteLine(digit2);
}