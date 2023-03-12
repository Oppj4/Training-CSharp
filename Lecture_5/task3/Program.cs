// Задача 3.
// Задайте массив. Напишите программу, которая
// определяет, присувствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

//Создаём массив и заполняем его значениями

int[] createRandIntElem(int size, int min, int max)
{   
    int[] array = new int[size];
    Random rnd = new Random();
    
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

//Метод печати массива.

void printArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write($"[{arr[i]}, ");
        else if(i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

//Метод поиска нужного элемента в массиве.

string findElem(int[] arr, int n)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == n) return $"Заданное число [{n}] есть в массиве!";
    }
    return $"Заданное число [{n}] отсувствует в массиве!";
}

int[] array = createRandIntElem(12, 0, 999);

Console.WriteLine("Сгенерированные массив:");
printArray(array);
Console.WriteLine("\nВведите число которое необходимо найти: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(findElem(array, num));