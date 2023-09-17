// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine()!);

void IsItWeekend (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Да, выходной.");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Нет такого дня недели.");
  }
  else Console.WriteLine("Нет, рабочий.");
}

IsItWeekend(dayNumber);
