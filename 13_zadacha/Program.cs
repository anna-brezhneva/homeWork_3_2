// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();
Console.WriteLine("Напишите любое число: ");
string str = Console.ReadLine();
int n = str.Length;
if (n < 2)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
    Console.WriteLine(str[2]);
}