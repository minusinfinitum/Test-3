// radius

using System;

Console.Write("Radiusni kiriting: ");
double radius = Convert.ToDouble(Console.ReadLine());

double area = Math.PI * Math.Pow(radius, 2);
double circumference = 2 * Math.PI * radius;

Console.WriteLine($"S= {area}, L= {circumference}");


// qiymat 

using System;

Console.Write("Qiymatni kiriting: ");
double qiymat = Convert.ToDouble(Console.ReadLine());

Console.Write("Kursni kiriting: ");
double kurs = Convert.ToDouble(Console.ReadLine());
double natija = qiymat * kurs;

Console.WriteLine($"Natija: {natija} so'm");
    
    

// yosh 
using System;

Console.Write("Tug'ilgan yilni kiriting: ");

int tugilganYil = Convert.ToInt32(Console.ReadLine());

int joriyYil = DateTime.Now.Year;
int yosh = joriyYil - tugilganYil;

Console.WriteLine($"Sizning yoshingiz: {yosh * 365} kun");