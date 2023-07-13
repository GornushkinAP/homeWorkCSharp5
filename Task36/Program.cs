// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int length = 10;
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100); 
}

int sum = 0;
for (int i = 1; i < length; i += 2)
{
    sum += array[i];
}
Console.WriteLine("Салют!");
Console.WriteLine("Массив: " + string.Join(", ", array));
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum + " Хорошего вечера!");
