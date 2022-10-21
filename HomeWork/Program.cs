// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*

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

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Dif (int n)
{
        while (n>=999)
        {
        
            n = n/10;
            
        }
    n = n % 10;

    return n;        

    }



Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
if (number <100)
{
    Console.WriteLine("Введенное число не имеет третьей цифры");

}

int Resultat = Dif (number);

Console.WriteLine($"Третья цифра в числе {number}  будет {Resultat}");



