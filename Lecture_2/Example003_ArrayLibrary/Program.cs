void FillArray(int[] collection)
{
    int arrayLength = collection.Length;
    int index = 0;
    while (index < arrayLength){
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.Write($"{col[position]} ");
        position++;
    }
}

int IndexOf(int[] collection, int find){
    int count = collection.Length;
    int FindInd = -1;
    int position = 0;
    
    while(position < count){
        if(collection[position] == find){
            FindInd = position;
            break;
        }
        position++;
    }
    return FindInd;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int resultInd = IndexOf(array, 4);
if(resultInd != -1) Console.WriteLine(resultInd);
else Console.WriteLine("В массиве нету искомого числа!");
