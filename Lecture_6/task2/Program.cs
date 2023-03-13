// Задача 1.
// Напишите программу, которая перевернёт
// одномерный массив(последний элемент будет
// на первом месте, а первый на последнейм и тд.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] CreateRndIntArr(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write($"]");
}

int[] ReverseArr(int[] arr)
{   
    int[] revArr = new int[arr.Length];

    int arrLen = arr.Length;
    for(int i = 0; i < arrLen; i++)
    {
        revArr[i] = arr[(arrLen - 1) - i];
    }
    return revArr;
}

int[] array = CreateRndIntArr(10, 1, 10);

PrintArray(array);
Console.WriteLine(" -> Изначальный\n");

PrintArray(ReverseArr(array));
Console.WriteLine(" -> Перевёрнутый\n");