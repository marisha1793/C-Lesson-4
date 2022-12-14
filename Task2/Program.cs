// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int sum = TheSumOfDigitsInANumber(N);
Console.WriteLine(sum);

int TheSumOfDigitsInANumber(int N)
{
    int sum = 0;
    for(int newN = N; newN > 0;)
    {
        int number = newN % 10;
        sum = sum + number;
        newN = newN /10;
    }

    return sum;
}