// Задача 2.
// Напишите программу для замены элементов массива:
// положительные элементы заменить на соответствующие
// отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

//создаём массив и заполняем его значениями.

int[] createRandIntArr(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// Метод печати массива

void printArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

// Меняем числа в массиве

int[] replaceElem(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}


int[] array = createRandIntArr(12, -9, 9);
Console.WriteLine("Начальный Массив:");
printArray(array);

Console.WriteLine("\nИзменённый Массив:");

int[] repArr = replaceElem(array);

printArray(repArr);