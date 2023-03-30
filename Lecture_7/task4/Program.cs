// Задача 4
// Задайте двумерный массив. Найдите сумму элементов,
// назодящихся на главной диагонали(с индексами (0, 0); (1, 1)) и тд.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1 + 9 + 2 = 12


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

int FindDiagonalSum(int[,] matr)
{

    int counter = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(i == j) matr[i, j] = counter += matr[i, j];
        }
    }
    return counter;
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

int[,] matrix = CreateRntIntMatrix(7, 10, 1, 9);

Console.WriteLine("Матрица: ");
printMartix(matrix);

int diagonalSum = FindDiagonalSum(matrix);
Console.WriteLine($"Сумма элементов главной диагонали: {diagonalSum}");
