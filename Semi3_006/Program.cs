/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98 */

int randomNumber = new Random().Next(100, 1000);
int lastDigit = randomNumber % 10;                  // нахождение первого числа
int firstDigit = randomNumber / 100;              // нахождение второго числа     
Console.WriteLine(randomNumber);

/*Console.Write(firstDigit);    //Console.WriteLine(firstDigit + "" + lastDigit);
Console.WriteLine(lastDigit);*/
Console.WriteLine($"{firstDigit}{lastDigit}");     // способ склеивания с интерполяцией вывод в одну строку

