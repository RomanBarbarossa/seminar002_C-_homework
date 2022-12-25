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

