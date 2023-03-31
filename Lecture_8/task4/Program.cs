// Задача 4.
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Набор данных              |      Частотный массив.    |
// --------------------------|---------------------------|
// {1, 9, 9, 0, 2, 8, 0, 9}  |      0 встречается 2 раза |
//                           |      1 встречается 1 раз  |
//                           |      2 встречается 1 раз  |
//                           |      8 встречается 1 раз  |
//                           |      9 встречается 3 раза |
// --------------------------|---------------------------|
// 1, 2, 3,                  |      1 встречается 3 раза | 
// 4, 6, 1,                  |      2 встречается 2 раза | 
// 2, 1, 6                   |      3 встречается 1 раз  |
//                           |      4 встречается 1 раз  |
//                           |      6 встречается 2 раза |
// --------------------------|---------------------------|

//Создание двумерного массива целых чисел.
int[,] CreateRntIntMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//Перевод двумерного массива 
int[] Array2DToArray(int[,] matrix)
{
    int arrLen = matrix.GetLength(0) * matrix.GetLength(1);
    int[] result = new int[arrLen];
    int counter = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            result[counter] = matrix[i, j];
            counter++;
        }
    }
    return result;
}

//Пузырьковая сортировка массива.
int[] BubbleSortArray(int[] arr)
{
    int arrLen = arr.Length - 1;
    int[] result = new int[arrLen + 1];
    if(arrLen <= 1) return result;

    bool flag = true;
    while(flag)
    {
        flag = false;
        for(int i = 0; i < arr.Length - 1; i++)
        {
            int temp = arr[i + 1];
            if(arr[i] > arr[i + 1]) 
            {
                arr[i + 1] = arr[i];
                arr[i] = temp;
                flag = true;
            }
        }
    }
    return arr;

}

void OccurrenceCounter(int[] arr)
{
    int counter = 1;
    int temp = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {

        if(arr[i] != temp || (i == (arr.Length - 1)))
        {
            if((i == (arr.Length - 1))) counter++;
            Console.WriteLine($"Значение {temp} встречается {counter} раз");
            temp = arr[i];
            counter = 1; 
        }
        else
        {
            temp = arr[i];
            counter++;
        }
    }
}

// Печать двумерного массива.
void PrintMartix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 4}, ");
            else Console.Write($"{matr[i, j], 4}");
        }    
        Console.WriteLine("|");
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[,] array2D = CreateRntIntMatrix(3, 4, 1, 10);
PrintMartix(array2D);
Console.WriteLine();

int[] array = Array2DToArray(array2D);
int[] sortArr = BubbleSortArray(array);
OccurrenceCounter(sortArr);