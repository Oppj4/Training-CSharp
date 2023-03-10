int[,] pic = new int[,]
{ 
    {0,0,0,0,0,1,1,1,1,1,0,0,0,0,0},
    {0,0,0,0,1,0,0,1,1,0,1,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,1,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,0},
    {0,0,0,1,1,1,0,0,0,1,1,1,0,0,0},
    {0,0,1,0,0,0,1,1,1,0,0,0,1,0,0},
    {0,0,1,0,0,0,1,0,1,0,0,0,1,0,0},
    {0,0,0,1,1,1,0,0,0,1,1,1,0,0,0},

};

void PrintPic(int[,] matr)
{   Console.WriteLine(matr.GetLength(0));
    Console.WriteLine(matr.GetLength(1));
    for(int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for(int col = 0; col < matr.GetLength(1); col++)
        {
            if(matr[rows, col] == 0) Console.Write($" ");
            else Console.Write("+");
        }
    Console.WriteLine();
    }
}
void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintPic(pic);
FillImage(11,4);
FillImage(8,8);
FillImage(11,11);
PrintPic(pic);