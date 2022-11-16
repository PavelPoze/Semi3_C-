//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.


int numb1 = ReadInt("Введите первое число: ");
int numb2 = ReadInt("Введите второе число: ");
//int remante = numb1 % numb2;
//if (remanted ==0)
if (numb1%numb2 !=0)     // !=0 значит не равно 0. т.е не кратно
{
    Console.WriteLine("НЕ кратно, остаток: " + numb1%numb2);
}
else 
{
    Console.WriteLine("Кратно");
}
// работает
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}