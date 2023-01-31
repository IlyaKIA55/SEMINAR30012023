//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int number(string message)
{
    Console.WriteLine(message);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}
int numberA = number("Введите число от 1 до 7: ");

if (numberA==6 || numberA==7)
{
   Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}