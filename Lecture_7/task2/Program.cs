// Задача 2
// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле:
// Amn = m + n.
// Выведите полученный массив на экран.

// m = 3, n = 4

// 0 1 2 3 
// 1 2 3 4
// 2 3 4 5


int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void printMartix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 4},");
            else Console.Write($"{matr[i, j], 4}");
        }    
        Console.WriteLine("]");
    }
}

int[,] matrix = CreateMatrix(3, 4);
printMartix(matrix);