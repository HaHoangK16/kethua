﻿using System;

namespace Cylinder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.setColor("Red");
            circle.setR(5);
            Console.WriteLine(circle.ToString());
            
            Cylinder cylinder = new Cylinder();
            cylinder.setColor("Blue");
            cylinder.setR(3);
            cylinder.setHeight(10);
            cylinder.getArea();
            Console.WriteLine(cylinder.ToString());
        }
    }
}
