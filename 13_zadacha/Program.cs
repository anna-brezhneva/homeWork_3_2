// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();
Console.WriteLine("Напишите любое число: ");
int a = int.Parse(Console.ReadLine());

if (a > 99)
{
   Console.WriteLine(a.ToString()[2]);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}