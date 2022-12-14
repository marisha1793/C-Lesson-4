// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

int numberA = RaisingTheNumberAToThePowerOfB (A, B);

Console.WriteLine(numberA);

int RaisingTheNumberAToThePowerOfB (int A, int B)
{
    int numberA = 1;
    for (int count = 1; count <= B; count++)
    {
        numberA = numberA*A;
    }

    return numberA;
}