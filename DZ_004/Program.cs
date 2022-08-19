// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arrayNumbers = new double[10];
for (int i = 0; i < arrayNumbers.Length; i++ )
{
    arrayNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayNumbers[i] + " ");
}
Console.WriteLine();

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

for (int i = 1; i < arrayNumbers.Length; i++)
{
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
}

double decision = maxNumber - minNumber;

Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
