using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada ees- ja perekonnanime
            //programmm kontrollib andmete pikkust (eraldi ees- ja perekonnanimi)
            //programm kuvab kum nendest on pikem, kas ees- või perekonnanimi. 

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit");
            int lastNameLenght = lastName.Length;
            Console.WriteLine($"Sinu perekonnanimes on {lastNameLenght} sümbolit");

            if (firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Sinu eesnimes eesnimi on pikem kui perekonnanimi");
            }

            else if (firstNameLenght < lastNameLenght)
            {
                Console.WriteLine("Sinu perekonnanim on pikem kui eesnimi");
            }

            else
            {
                Console.WriteLine("Mõlemad nimed on sama pikad");
            }

        }
    }
}
