using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proramm käsib kasutajal sisestada ees- ja perekonnanime
            //Programm kuvab, mitu "a" tähte on kasutaja ees- ja perekonnanimes kokku.

            Console.WriteLine("Sisesta palun enda eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta palun enda perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName} {lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName [i] == 'a') //char a = 'a';
                {
                    aCounter++;
                }
            }

            if(aCounter !=1)
            {
                Console.WriteLine($"Sinu ees- ja perekonnanimes {fullName} on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu ees- ja perekonnanimes {fullName} on {aCounter} 'a' täht.");
            }


        }
    }
}
