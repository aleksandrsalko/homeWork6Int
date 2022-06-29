/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
  значения b1, k1, b2 и k2 задаются пользователем.
  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

double b1 = Input("Введите значения b1: ");
double k1 = Input("Введите значения k1: ");
double b2 = Input("Введите значения b2: ");
double k2 = Input("Введите значения k2: ");

double x = (b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых({x}; {y})");

double Input(string output)
{
Console.Write(output);
return Convert.ToDouble(Console.ReadLine());
}

