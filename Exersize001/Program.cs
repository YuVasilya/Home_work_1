﻿Console.WriteLine("Программа ищет максимальное число из двух данных");
int a;
Console.Write("Number a = ");
a = Convert.ToInt32(Console.ReadLine());
int b;
Console.Write("Number b = ");
b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);