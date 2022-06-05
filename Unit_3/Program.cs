// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int Length)
{
    int[] result = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
return result;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
        Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
int summ(int[] Array)
{
    int summ = 0;
    for (int i = 1; i < Array.Length; i = i+2)
    {
        summ = summ + Array[i];
    }
    return summ;
}



int[] NewArray = FillArray(5);
printArray(NewArray);
int newsumm = summ(NewArray);
Console.WriteLine($"Сумма чисел массива, стоящих на нечетных позициях, равна: {newsumm}");