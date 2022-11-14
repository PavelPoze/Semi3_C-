int[] array = { 1, 22, 2, 4, 223, 54, 8, 765, 4 };

int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index]== find)
    {
        Console.WriteLine(index);
        break;
    }
   // index = index =1;
    index++;
}