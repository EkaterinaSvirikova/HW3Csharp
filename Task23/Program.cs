// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System; 
using static System.Console; 

Clear();

Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i <= number)
{
    
    WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}"); // вывод таблицы
    // Write($"{Math.Pow(i, 3)} ");                   // вывод в строку
    i++;
}
WriteLine();

