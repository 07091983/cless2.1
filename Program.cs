// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a % 100;
int a2 = a1 % 10;
if (a < 1000)

{
      Console.WriteLine(a);
      Console.WriteLine(a1);
      Console.WriteLine(a2);
}
if (a < 100)
{
     Console.WriteLine($"нет {0}");
}

if (a > 1000)
{
    Console.WriteLine($" {a1 = a / 100}; {a2 = a1 % 10}");
}