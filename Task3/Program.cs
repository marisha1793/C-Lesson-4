// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите массив из 8 случайных элементов: ");
int[] array = CreateRandomArray();
PrintArray(array);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

int[] CreateRandomArray()
{
    Random random = new Random();
    int[] array = new int [8];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,100);
    }
    return array;
}


