// Задача 3
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, замените эти элементы
// на их квадраты.

// Например, изначально массив выглядел так :
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 

// Новый массив будет выглядеть вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4

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

int[,] ChangeElemMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if((j % 2 == 0) & (i % 2 == 0)) matr[i, j] = matr[i, j] * matr[i, j];
        }
    }
    return matr;
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

Console.WriteLine("Начальная матрица:");
int[,] matrix = CreateRntIntMatrix(3, 4, -9, 9);
printMartix(matrix);

Console.WriteLine("Изменённая матрица:");
int[,] newMatrix = ChangeElemMatrix(matrix);
printMartix(newMatrix);