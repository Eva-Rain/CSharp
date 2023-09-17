// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
string digit3 = Convert.ToString(number);
if (digit3.Length > 2)
{
  Console.WriteLine("Третья цифра:" + digit3[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет.");
}