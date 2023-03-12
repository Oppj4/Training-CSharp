// Задача 4.
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10, 99].

// Пример для массива из 5, а не 123 элементов.

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] createRndIntArr(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void printArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

int findElem(int[] arr)
{   
    int counter = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if( (arr[i] >= 10) && (arr[i] <= 99) ) counter++;
    }
    return counter;
}

int[] array = createRndIntArr(123, 1, 999);

Console.WriteLine("Сгенерированный массив:\n");
printArray(array);

Console.WriteLine($"\n\nКол-во элементов в диапозоне от [10, 99] = {findElem(array)}");
