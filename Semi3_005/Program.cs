// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
Например:
78 -> 8
12-> 2
85 */


int randomNumber = new Random().Next(10, 100);   //  создание случайного числа
int lastDigit = randomNumber % 10;                  // нахождение первого числа
int firstDigit = randomNumber / 10;              // нахождение второго числа     
Console.WriteLine(randomNumber);
if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine(firstDigit);
}
// работает!!!



 
