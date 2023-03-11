// Задача 7.
// Напишите программу которая
// выводит массив из 8 элементов,
// заполнение нулями и единицами происходит
// в случайном порядке.
// [1,0,1,0,1,1,0,1]

int[] Array = new int[8];

void fill_array(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }

}
void print_array(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {   
        if(i == 0) Console.Write($"[{arr[i]}, ");
        else if(i == arr.Length-1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

fill_array(Array);
print_array(Array);