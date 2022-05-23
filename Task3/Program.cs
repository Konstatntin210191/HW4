// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void GetFillArray(int[] collection)
{
    Random randomaiser = new Random();
    for( int i = 0; i < collection.Length; i++)
    {
        collection[i] = randomaiser.Next(0, 9);
    }
}

int[] array = new int[8];
GetFillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

