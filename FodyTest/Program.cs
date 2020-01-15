using System;

namespace FodyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDTO p = new PersonDTO();
            Log(p);

            p.Forename = "Martin";
            Log(p);

            p.Surname = "Stephenson";
            Log(p);

            p.DateOfBirth =  DateTime.Now;
            Log(p);

            Console.ReadKey();
        }

        private static void Log(PersonDTO p) {
            Console.WriteLine($"Forename: {p.Forename} | Surname: {p.Surname} | DOB: {p.DateOfBirth.ToString()}");
            Console.WriteLine(p.ObjectState.ToString());
            Console.WriteLine($"Modified properties : {p.ModifiedProperties.Count}");
            foreach (var item in p.ModifiedProperties)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("----------");
        }
    }
}
