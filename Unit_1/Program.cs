// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
}
    
int[] fillArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
       result[i] = new Random().Next(100, 1000);
    }
return result;
}

int numbersEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if(array[i] % 2 == 0)
      {
        result++;
      }
    }
return result;
}

Console.WriteLine("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = fillArray(lenght);
printArray(array);
int evenNumbers = numbersEven(array);
Console.WriteLine("");
Console.WriteLine($"Количество четных чисел в массиве равно: {evenNumbers}" );
