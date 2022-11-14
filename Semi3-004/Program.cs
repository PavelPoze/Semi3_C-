// задание массива коммандой (new int[n]), по умолчание массив будет заполнен 0, добваим новую комманду
//void оператор
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int posinion = -1;// если нет в массиве нет искомого значения он будет отображен как -1

    while (index < count)
    {
        if (collection[index] == find)
        {
            posinion = index;
            break;// остановка счетчика для отображения первого индекса
        }
        index++;
    }
    return posinion;
}

int[] array = new int [10];


//FillArray  медот заполнения массива, PrintArray  метод написания массива
FillArray(array);
PrintArray(array);
Console.WriteLine();


int pos = IndexOf(array, 4);
Console.WriteLine(pos);