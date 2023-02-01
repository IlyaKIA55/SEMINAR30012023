// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Как сделать так что бы при выводе сообщения "третьей цифры нет" 
// небыло ноля вконце строки?

int Number(string message)
{
    Console.WriteLine(message);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

int number = Number("Введите число: ");
int count = number.ToString().Length;
Console.WriteLine(Array(number, count));


int Array(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
        result = (a / c) % 10;
    }
return result;
}