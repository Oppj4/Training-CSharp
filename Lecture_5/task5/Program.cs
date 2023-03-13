// Задача 5.
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй
// и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateRandIntArr(int size, int min, int max)
{
    int[] array = new int[size];
    Random rdn = new Random();

    for(int i = 0; i < size; i++)
    {
        array[i] = rdn.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length-1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, "); 
    }
}

int[] SumNumsInArray(int[] arr)
{   
    int arrLen = arr.Length;
    int arrLenTemp;
    if(arr.Length % 2 == 0) arrLenTemp = arr.Length / 2;
    else arrLenTemp = arr.Length / 2 + 1;
    int[] result = new int[arrLenTemp];

    for(int i = 1; i < arrLen / 2 + 1; i++)
    {   

        result[i-1] = arr[i-1] * arr[arrLen - i];

    }
    if(arrLen % 2 != 0) result[arr.Length / 2] =  arr[arr.Length / 2];
    return result;

}

int[] array = CreateRandIntArr(5, 1, 20);

PrintArray(array);

Console.WriteLine();

int[] sumArr = SumNumsInArray(array);
PrintArray(sumArr);