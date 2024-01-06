using System;

Console.Write("Radiusni kiriting: ");
double radius = Convert.ToDouble(Console.ReadLine());

double area = Math.PI * Math.Pow(radius, 2);
double circumference = 2 * Math.PI * radius;

Console.WriteLine($"S= {area}, L= {circumference}");
