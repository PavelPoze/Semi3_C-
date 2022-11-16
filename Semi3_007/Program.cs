//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

Console.WriteLine("Введите число1: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
//int ost = 
if (numb1%numb2 !=0)     // !=0 значит не равно 0. т.е не кратно
{
    Console.WriteLine("НЕ кратно, остаток: " + numb1%numb2);
}
else 
{
    Console.WriteLine("Кратно");
}
// работает