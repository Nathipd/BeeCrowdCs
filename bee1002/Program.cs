﻿using System;
using System.Globalization;
namespace bee1002{
    class Program{
        static void Main(string[] args){
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = n * Math.Pow(raio, 2);
            System.Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}