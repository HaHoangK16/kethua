﻿using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Change();

            Student s1 = new Student(111,"Hoang");
            Student s2 = new Student(222,"Phuoc");
            Student s3 = new Student(333,"Nam");

            s1.Display();
            s2.Display();
            s3.Display();
        }
    }
}
