// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int TwoNumber(int number)
{
    
    int ed  = number / 10;
    number = ed % 10;
    
    return number;

}

Console.Write("Input a three - digit number: ");
int n = Convert.ToInt32(Console.ReadLine());


int result = TwoNumber(n);
Console.WriteLine($"Two digital of a number {n} is {result}");

