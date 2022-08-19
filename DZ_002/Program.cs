// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array [i]} ");
    Console.WriteLine();
}

int[] array = CreateArray(10, 0, 100);
PrintArray(array);

int countEven = 0;
int countNotEven = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) countEven = countEven + 1;
    else countNotEven = countNotEven + 1;
}
Console.WriteLine("Четные числа из массива: " + countEven);
Console.WriteLine("Нечетные числа из массива: " + countNotEven);
