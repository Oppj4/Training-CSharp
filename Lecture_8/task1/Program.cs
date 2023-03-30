// Создание массива с вещественными числами по диапазону
// Описание получием:
// https://learn.microsoft.com/ru-ru/dotnet/api/system.random?view=net-6.0#Floats



double[,] CreateRntDblMatrix(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            double rand = rnd.NextDouble() * (max - min) + min; // Формула из документации
            matrix[i, j] = Math.Round(rand, 2);

        }
    }
    return matrix;
}


void printMartix(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 5},");
            else Console.Write($"{matr[i, j], 5}");
        }    
        Console.WriteLine("]");
    }
}


double[,] array2D = CreateRntDblMatrix(3, 4, -10, 40);
printMartix(array2D);