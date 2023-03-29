// Задайте двумерный массив размером m x n,
// заполненный случайнымы целыми числами.

// m = 3, n = 4

// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int[,] CreateRandomMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

int[,] matrix = CreateRandomMatrix(3, 4, -19, 10);
printMartix(matrix);