// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
string M = N.ToString();

if (N <= 9999 || N >= 100000)
{
    Console.Write("Введите пятизначное число");

}
else if (M[0] == M[4] && M[1] == M[3])
{
    Console.Write(N + "-> да");
}
else
{
    Console.Write(N + "-> нет");
}