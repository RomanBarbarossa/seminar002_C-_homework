// // Задача 1: Напишите программу, которая принимает на вход 
// // трёхзначное число и на выходе показывает вторую цифру этого числа. 
// // Обязательна проверка на ввод чисел больше/меньше 3-х знаков

// Console.WriteLine("Введите трёхзначное число");
// int number = int.Parse(Console.ReadLine()!);
// if(number < 1000 && number > 99)
// {
//     Console.WriteLine((number % 100)/10);
// }

//     else
//     {
//         Console.WriteLine("Ошибка, введите трёхзначное число");
//     }
// Задача 2: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Берем числа до 100000

// Console.WriteLine("Введите число до 100000");
// int number = int.Parse(Console.ReadLine()!);
// if(number < 100000 && number > 9999)
// {
//     Console.WriteLine((number % 1000)/100);
// }
// if(number < 10000 && number > 999)
// {
//     Console.WriteLine((number % 100)/10);
// }
// if(number < 1000 && number > 99)
// {
//     Console.WriteLine(number % 10);
// }
// if(number < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if(number > 100000)
// {
//     Console.WriteLine("Ошибка! Вы ввели число больше нужного");
// }

//  Решение2:
// Console.WriteLine("Введите число  ");
// string number = Console.ReadLine()!;

// if(number.Length > 6)
// {
//     Console.WriteLine("Ошибка,вы ввели число ,более 100000");
// }
  
// if(number.Length < 3)
// {
//     Console.WriteLine("Третьей цифры нет!");
// }
//   else
//     {
//         Console.WriteLine(number[2]);
//     }

// Задача 3: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным. 
// Обязательна проверка на ввод числа <1 и >7

Console.Write("Введите число:  ");
int day = int.Parse(Console.ReadLine()!);
int dayoff1 = 6;
int dayoff2 = 7;
if(day == 1)
{
    Console.WriteLine("Понедельник");
}
if(day == 2)
{
    Console.WriteLine("Вторник");
}
if(day == 3)
{
    Console.WriteLine("Среда");
}
if(day == 4)
{
    Console.WriteLine("Четверг");
}
if(day == 5)
{
    Console.WriteLine("Пятница");
}
if(day == 6)
{
    Console.WriteLine("Суббота");
}
if(day == 7)
{
    Console.WriteLine("Воскресенье");
}
if(day > 7 || day < 1)
{
    Console.WriteLine("Fatal Error. Choose again");
}
if(day == dayoff1 || day == dayoff2)
{
    Console.WriteLine("Выходной");
}
