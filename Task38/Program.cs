// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Приветики");
double[] numbers = { 3.14, 2.71, 1.618, 10.577, 4.669 }; 
double min = numbers[0]; 
double max = numbers[0]; 

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }

    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

double difference = max - min; 

Console.WriteLine($"Разница между макс и мин элементами: {difference}");
Console.WriteLine("Досвидания!");