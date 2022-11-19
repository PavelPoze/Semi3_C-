/*Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/
while (true)   // добавили условия если пользователь ввел числа не верные,
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
