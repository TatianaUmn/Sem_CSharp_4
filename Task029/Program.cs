// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100); 
        // ограничила числа в массиве двухзначными, т.к. так указано в примере
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{col[i]}, ");
    }
}
int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();