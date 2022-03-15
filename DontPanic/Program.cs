using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga - 0
            //programm asendab kõik 'a' tähed lauses "Don't Panic"4-ga.

            string lauseP = "Don't Panic!";

            lauseP = lauseP.Replace('o', '0');
            lauseP = lauseP.Replace('a', '4');
            Console.WriteLine(lauseP);


            /*string helloW = "Hello World!";

             for (int i = 0; i < helloW.Length; i++)
             {
                 helloW[i] = '*'; //sõned on muutumatud
             } 
            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
            
             */

        }

    
    }
}
