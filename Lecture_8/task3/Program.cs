// Задача 3.
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.



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


int[,] ReplaceRowsWithCols(int[,] matrix)
{
    int[,] resultMatr = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            resultMatr[i, j] = matrix[j, i];
        }
    }
    return resultMatr;
}


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

int[,] array2D = CreateRntIntMatrix(4, 4, 1, 10);
PrintMartix(array2D);

Console.WriteLine();
if(array2D.GetLength(0) == array2D.GetLength(1))
{
    int[,] newArray2D = ReplaceRowsWithCols(array2D);
    PrintMartix(newArray2D);
}
else{Console.WriteLine("Операция невозможна!");} 


