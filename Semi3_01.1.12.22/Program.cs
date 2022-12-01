/*
int size = ReadInt("задайте массив ");                     // начало работы  
int[] number = new int[size];                              // создание массива от указанного числа числа

FillArrayRandomNumbers(number, 1,10);                      // определение интевала случайных числел массива
WriteArray(number);                                        // печать массива в консоль
int max = number[0];                                       // создание максимальной переменной
int min = number[0];                                       // сздание минимальной переменной                        

for (int i = 0; i < number.Length; i++)
{
    if (max < number[i])
    {
        max = number[i];
    }
     if (min > number[i])
    {
        min = number[i];
    }
}
int result = max - min;              // искомое значение
Console.WriteLine(result);
void WriteArray(int[] array)                                 //  создние массива
{
    for ( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FillArrayRandomNumbers(int[] array, int min, int max)   // заполенеие массива
{
    for (int i = 0; i < array.Length; i++)
    { 
        array[i] = new Random().Next(min, max+1);
    }

}
int ReadInt(string message)                                  // ввод числа
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/


/*Денис: Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/
/*

int number1 = ReadInt("Введите длину первой стороны: ");
int number2 = ReadInt("Введите длину второй стороны: ");
int number3 = ReadInt("Введите длину третьей стороны: ");
if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
{
    Console.WriteLine("Трейгольник есть");
}
else
{
    Console.WriteLine("Треугольника нет");
}
int ReadInt(string message)                                  // ввод числа
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/




/*Денис: Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */
int number = ReadInt("Введите деситичное число: ");
int temp = number;
string binary = "";

while (temp != 0)
{
    binary += Convert.ToString(temp%2);
    temp /= 2; 
}
string result = "";
for (int i = binary.Length-1; i >= 0; i--)
{
    result += binary[i];
}
Console.WriteLine($"Десятичное число {number} = {result} в двоичной сисеме.");
//Console.WriteLine(binary);
int ReadInt(string message)                                  // ввод числа
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}