// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System; 
using static System.Console; 

Clear();

Write("Введите координату точки А по оси X: ");
int x1 = int.Parse(Console.ReadLine());
Write("Введите координату точки А по оси Y: ");
int y1 = int.Parse(Console.ReadLine());
Write("Введите координату точки A по оси Z: ");
int z1 = int.Parse(Console.ReadLine());
Write("Введите координату точки B по оси X: ");
int x2 = int.Parse(Console.ReadLine());
Write("Введите координату точки B по оси Y: ");
int y2 = int.Parse(Console.ReadLine());
Write("Введите координату точки B по оси Z: ");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
WriteLine();
WriteLine($"Расстояние между двумя точками в 3D пространстве равно: {Math.Round(distance, 2)}"); // мой вариант округления
WriteLine();
//WriteLine($"Расстояние между двумя точками на плоскости равно: {distance:f2}"); // вариант округдения препода
//WriteLine($"Расстояние между двумя точками на плоскости равно: {distance:p2}"); // вариант округдения препода вывод в процентах

