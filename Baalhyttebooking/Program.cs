using System;

namespace Baalhyttebooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1");
            Console.WriteLine("Test Kreds klassen");

            Boernegruppe b1 = new Boernegruppe("GruppeEt", "Bjørnene", "Pusling" ,6);
            Boernegruppe b2 = new Boernegruppe("GruppeTo", "Snoerne", "Tumling" ,3);
            Console.WriteLine(b1);

            Console.WriteLine(b2);
            Console.WriteLine();


            Console.WriteLine("Opgave 2");
            Console.WriteLine("Test Reservation klassen");

            Reservation r1 = new Reservation("GruppeEt", new DateTime().AddHours(14).AddMinutes(00), new Boernegruppe());
            Reservation r2 = new Reservation("Gruppeto", new DateTime().AddHours(14).AddMinutes(00), new Boernegruppe());

            Console.WriteLine(r1);
            Console.WriteLine();
            Console.WriteLine(r2);
            Console.WriteLine();



        }




    }
}