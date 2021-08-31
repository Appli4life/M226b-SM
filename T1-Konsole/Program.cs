using System;

namespace T1_Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs k = new Kurs("253-2332-22");
            k.Kursname = "C# Kurs";
            Professor per = new Professor("Bill Gates","peter@gamil.com",30,"23534324234-0", new Adresse("Neuhofweg", "34", "4102", "Binningen", "Schweiz"),k);
            Student stu = new Student("Simon Müller", "simon.mueller@gamil.com", "34242", new Adresse("Neuhofweg", "34", "4102", "Binningen", "Schweiz"), 2);
            stu.besucht.Add(k);

            Console.WriteLine(stu);
            Console.WriteLine(per);
            Console.ReadLine();
        }
    }
}
