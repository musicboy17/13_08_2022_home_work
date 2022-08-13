﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X первой точки: ");
int x1 = Convert.ToInt(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = Convert.ToInt(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int z1 = Convert.ToInt(Console.ReadLine());


Console.Write("Введите координату X второй точки: ");
int x2 = Convert.ToInt(Console.ReadLine());
Console.Write("Введите координату Y вторвой точки: ");
int y2 = Convert.ToInt(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z2 = Convert.ToInt(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2,2) + (y1 - y2,2) + (z1 - z2,2));

Console.WriteLine($"Расстояние равно: {Math.Round(result,2)}");



