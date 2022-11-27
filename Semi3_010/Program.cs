
int number = Convert.ToInt32(Console.ReadLine());
int countDigit = 0;
int sum = 0;

int temp = number;
while (temp > 0)
{
    countDigit++;
    temp /= 10;
}

int[] numbers = new int[countDigit]; // создаем массив от размера числа
int index = 0;
while (number > 0)
{
    numbers[index++] = number % 10;
    number /= 10;
}


// Из чата решение Дениса
string stringNumber = Console.ReadLine();
int sum = 0;

for (int i = 0; i < stringNumber.Length; i++)
{
    string digit = Convert.ToString(stringNumber[i]);
    sum += Convert.ToInt32(digit);
}

Console.WriteLine(sum);

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);










Денис: дмашняя задача
string stringNumber = Console.ReadLine();
int number = Convert.ToInt32(stringNumber);
int countDigit = 0;
int sum = 0;

int[] numbers = new int[stringNumber.Length];
int index = 0;
while (number > 0)
{
    numbers[index++] = number % 10;
    number /= 10;
}

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);




Денис: решение с массивом 
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 0, 10);
WriteArray(numbers);


void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


