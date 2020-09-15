using System;

namespace ClassStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "M.Hoang", "Hue", 20);

            Student student2 = new Student();
            student2.SetId(2);
            student2.SetName("N.Phuoc");
            student2.SetAddress("Hue");
            student2.SetAge(22);

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.Read();
        }
    }
}
