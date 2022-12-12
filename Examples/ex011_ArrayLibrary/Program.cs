void FillArray(int[] collection) //создаем массив
{
    int length = collection.Length; //длинна массива
    int index = 0;
    while(index < length) //пока индекс меньше длинны
    {
        collection[index] = new Random().Next(1,10); //наполнение массива случайными числами в дипазоне 1-10
        index++;
    }
}

void PrintArray(int[]col) //Печатаем массив
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 15);
Console.WriteLine(pos);