using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtubu kasutajaga homme. (kasutame random klassi)

            string[] predictions = {"win a millon", "fall in love", "buy youtube premium", "join the darkside for cookis"};

            Random rnd = new Random();
            int userNumber= rnd.Next(0, predictions.Length );

            Console.WriteLine($"Tommorow you will {predictions[userNumber]}.");

            /* 
            //programm ennustab, mis puuvilja kasutaja sööb. 

            //string[] fruit = new string[5];
            string[] fruit = new string[5] {"an apple", "a banana", "a lemon", "an orange", "some grapes"};

            //Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);
            //... jne kuni 4

            //Console.WriteLine("Enter a number from 0-4:");
            //int userNumber = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length );

            Console.WriteLine($"Today you will have {fruit[userNumber]}."); 

             */


        }
    }
}
