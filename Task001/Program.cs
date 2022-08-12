using static System.Console;
// Задача 0
Clear(); //Очищает терминал
Write("Введите число: "); //
int number = Convert.ToInt32(ReadLine()); //Convert.ToInt32 можно заменить int.Parse
int sqr = number * number;
WriteLine($"Квадрат числа {number}={sqr}");
