// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("И снова Здравствуйте!");
int arrayLength = 100;
int[] numbers = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    numbers[i] = new Random().Next(100, 1000);
    Console.Write(numbers[i] + " ");
}

int evenCount = 0;
for (int i = 0; i < arrayLength; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenCount++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел: " + evenCount);
Console.WriteLine("Досвидания.");