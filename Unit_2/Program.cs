// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

void summ(int[] Array)
{
    int summ = 0;
    for (int i = 0; i < Array.Length/2; i++)
    {
        summ = Array[i] * Array[Array.Length-1-i];
        Console.WriteLine(summ);
    }
}

int Length = 3;
int[] newArray = FillArray(Length);
printArray(newArray);
summ(newArray);