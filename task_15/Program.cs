// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 && num <= 31)
{
    if (num % 7 == 6 || num % 7 == 0)
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}
else 
{
    Console.WriteLine("В месяце не может быть день с такой датой");
}