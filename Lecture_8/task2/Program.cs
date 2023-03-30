// Задача 2.
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


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


int[,] changeRowsPosition(int[,] matrix, int pos1, int pos2)
{
    for(int i = 0; i < 1; i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            int tempPos1 = 0;
            int tempPos2 = 0;
            tempPos1 = matrix[pos1, j];
            tempPos2 = matrix[pos2, j];
            matrix[pos1, j] = tempPos2;
            matrix[pos2, j] = tempPos1;
        }
    }
    return matrix;
}   


void printMartix(int[,] matr)
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


int[,] array2D = CreateRntIntMatrix(3, 4, 0, 10);
printMartix(array2D);
Console.WriteLine();

int[,] newArray2D = changeRowsPosition(array2D, 0, 2);
printMartix(newArray2D);
Console.WriteLine();