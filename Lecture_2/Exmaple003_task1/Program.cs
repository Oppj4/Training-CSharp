// Задание1:
// Имеется одномерный массив array из n элементов,
// требуется найти элемент, равный find.

int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};

int arrayLen = array.Length;
int index = 0;

int find = 15;

while(index < arrayLen){
    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
};