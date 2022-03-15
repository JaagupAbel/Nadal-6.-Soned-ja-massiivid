using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello world!"
             

            /*Console.WriteLine("Korda minu järel: Hello World!");*/

            string lauseHello = "Hello World!".ToLower();

            int hCounter = 0;

            for (int i = 0; i < lauseHello.Length; i++)
            {
                if (lauseHello[i] == 'h')
                {
                    hCounter++;
                }
                    
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' sümbolit.");
            }
            else
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' sümbol.");
            }


            int oCounter = 0;


            for (int i = 0; i < lauseHello.Length; i++)
            {
                if (lauseHello[i] == 'o')
                {
                    oCounter++;
                }

            }

            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' sümbolit.");
            }
            else
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' sümbol.");
            }



            int lCounter = 0;


            for (int i = 0; i < lauseHello.Length; i++)
            {
                if (lauseHello[i] == 'o')
                {
                    lCounter++;
                }

            }

            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' sümbolit.");
            }
            else
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' sümbol.");
            }

        }
    }
}
