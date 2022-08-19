// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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

int count = 0;
for (int j = 0; j < array.Length; j+=2)
{
    count = count + array[j];
}
Console.WriteLine();
Console.Write("Сумма чисел стоящих на нечетной позиции в массиве равна - ");
Console.Write(count);
