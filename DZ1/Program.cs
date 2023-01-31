// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int numberRequest(string message)
{
    Console.WriteLine(message);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

int numberA = numberRequest("Введите 3х значное число: ");

numberA = (numberA/10) %10;

Console.WriteLine(numberA);