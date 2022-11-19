/*Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/
/*while (true)   // добавили условия если пользователь ввел числа не верные,
               // то программа будет запрашивать числа пока не введут правильные значения
{
    int x = ReadInt("Введите точку x: ");
    int y = ReadInt("Введите точку y: ");
    if (x == 0 || y == 0)
    {
        Console.WriteLine("x и y не могут быть равны 0");
        //return;  //выход из программы
        continue; // пропускает цикл и идет дальше
    }

    if (x > 0 && y > 0)
    {
        Console.WriteLine(" 1 ");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine(" 2 ");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine(" 3 ");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine(" 4 ");
    }
    break; // остановиит цикл while
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
//задача первая решена и работает

//Вторая задача
/*Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).*/
/*
int quarter = ReadInt("Введите четверть: ");

if (quarter == 1)
 {
    Console.WriteLine(" x > 0 , y >0");
 }
 if (quarter == 2)
 {
    Console.WriteLine(" x < 0 , y >0");
 }
 if (quarter == 3)
 {
    Console.WriteLine(" x < 0 , y <0");
 }
 if (quarter == 4)
 {
    Console.WriteLine(" x > 0 , y < 0");
 }
 else 
 {
    Console.WriteLine("НЕ верное значение всего 4");
 }

 switch (quarter)      // этой функцией можно заменить занчения (if)
                       // кейс  работает быстрее проверяет сразу на заданную цифру
 {
    case 1:
        Console.WriteLine(" x > 0 , y >0");
        break;
    case 2:
        Console.WriteLine(" x < 0 , y >0");
        break;
    case 3:
        Console.WriteLine(" x < 0 , y <0");
        break;
    case 4:
        Console.WriteLine(" x > 0 , y < 0");
        break;
    default:        // пишется только если нужно делать еще действие следующее действие
        Console.WriteLine(" Всего 4!");
        break;            
 }


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}*/
 //работает 

 //Третья задача
  /*Напишите программу, которая принимает на вход координаты двух точек 
  и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
/*
int x1 = ReadInt("Введите координаты Х1: ");
int y1 = ReadInt("Введите координаты B1: ");

int x2 = ReadInt("Введите координаты Х2: ");
int y2 = ReadInt("Введите координаты B2: ");

int a = x2 - x1;
int b = y2 - y1;

double result = Math.Sqrt(a*a+b*b);

Console.WriteLine($"Расстояние равно = {result}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
//работает расстояние найдено

/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
/*
int number = ReadInt("Введите число: ");
 int count = 1;

 while (count <= number)
 {
    Console.Write($"{count*count} ");
    count ++;
 }
 Console.WriteLine();

 int ReadInt(string message)
 {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
 }
*/
 //работает 