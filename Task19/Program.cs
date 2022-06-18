/// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

using System;
using static System.Console;

Clear();

Write("Введите пятизначное число: ");
string text = ReadLine();
char[] obrtext = text.ToCharArray();
Array.Reverse(obrtext);
string finaltext = new string(obrtext);
WriteLine();
if(text==finaltext)
 {
    WriteLine($" Число {text} является палиндромом");
}
if (text!=finaltext)
{
    WriteLine($"Число {text} не является палиндромом");
}
WriteLine();

